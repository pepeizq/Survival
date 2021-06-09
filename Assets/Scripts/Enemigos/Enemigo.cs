using UnityEngine;
using UnityEngine.AI;

namespace Enemigos
{
    public enum IATipo
    {
        Pasiva,
        Asustada,
        Agresiva
    }

    public enum IAEstado
    {
        Ausente,
        Deambulando,
        Atacando,
        Huyendo
    }

    public class Enemigo : MonoBehaviour
    {
        [Header("Atributos")]
        public int vida;
        public float andarVelocidad;
        public float correrVelocidad;
        public Assets.Objeto[] objetosSueltaAlMorir;

        [Header("IA")]
        public IATipo iaTipo;
        private IAEstado iaEstado;
        public float distanciaDetectar;
        public float distanciaSeguridad;

        [Header("Deambulando")]
        public float distanciaMinimaDeambulando;
        public float distanciaMaximaDeambulando;
        public float tiempoMinimoEspera;
        public float tiempoMaximoEspera;

        [Header("Combate")]
        public int daño;
        public float ataqueVelocidad;
        private float ultimaVezAtacoTiempo;
        public float distanciaAtaque;

        private float distanciaJugador;

        private NavMeshAgent agente;
        private Animator animador;
        private SkinnedMeshRenderer[] meshRenderers;

        public void Awake()
        {
            agente = GetComponent<NavMeshAgent>();
        }

        public void Start()
        {
            CambiarEstado(IAEstado.Deambulando);
        }

        public void Update()
        {
            distanciaJugador = Vector3.Distance(transform.position, Jugador.Movimientos.instancia.transform.position);

            switch (iaEstado)
            {
                case IAEstado.Ausente:
                    ActualizacionAusente(); 
                    break;

                case IAEstado.Deambulando:
                    ActualizacionAusente();
                    break;

                case IAEstado.Atacando:
                    ActualizacionAtacando();
                    break;

                case IAEstado.Huyendo:
                    ActualizacionHuyendo();
                    break;
            }
        }

        public void ActualizacionAusente()
        {
            if (iaEstado == IAEstado.Deambulando && agente.remainingDistance < 0.1f)
            {
                CambiarEstado(IAEstado.Ausente);
                Invoke("BuscarNuevaPosicion", Random.Range(tiempoMinimoEspera, tiempoMaximoEspera));
            }

            if (iaTipo == IATipo.Agresiva && distanciaJugador < distanciaDetectar)
            {
                CambiarEstado(IAEstado.Atacando);
            }
            else if (iaTipo == IATipo.Asustada && distanciaJugador < distanciaDetectar)
            {
                CambiarEstado(IAEstado.Huyendo);
            }
        }

        public void ActualizacionAtacando()
        {

        }

        public void ActualizacionHuyendo()
        {

        }

        public void CambiarEstado(IAEstado nuevoEstado)
        {
            iaEstado = nuevoEstado;

            switch (iaEstado)
            {
                case IAEstado.Ausente:
                {
                    agente.speed = andarVelocidad;
                    agente.isStopped = true;
                    break;
                }                   

                case IAEstado.Deambulando:
                {
                    agente.speed = andarVelocidad;
                    agente.isStopped = false;
                    break;
                }

                case IAEstado.Atacando:
                {
                    agente.speed = ataqueVelocidad;
                    break;
                }

                case IAEstado.Huyendo:
                {
                    agente.speed = ataqueVelocidad;
                    break;
                }
            }
        }

        public void BuscarNuevaPosicion()
        {
            if (iaEstado != IAEstado.Ausente)
            {
                return;
            }

            CambiarEstado(IAEstado.Deambulando);
            agente.SetDestination(CalcularNuevaPosicion());
        }

        public Vector3 CalcularNuevaPosicion()
        {
            NavMeshHit hit;
            NavMesh.SamplePosition(transform.position + (Random.onUnitSphere * Random.Range(distanciaMinimaDeambulando, distanciaMaximaDeambulando)), out hit, distanciaMaximaDeambulando, NavMesh.AllAreas);

            int i = 0;

            while (Vector3.Distance(transform.position, hit.position) < distanciaDetectar)
            {
                NavMesh.SamplePosition(transform.position + (Random.onUnitSphere * Random.Range(distanciaMinimaDeambulando, distanciaMaximaDeambulando)), out hit, distanciaMaximaDeambulando, NavMesh.AllAreas);

                i += 1;

                if (i == 20)
                {
                    break;
                }
            }

            return hit.position;
        }
    }
}

