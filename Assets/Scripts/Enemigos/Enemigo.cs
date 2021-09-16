using System.Collections;
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

    public class Enemigo : MonoBehaviour, iDañable
    {
        public Assets.Enemigo asset;

        [Header("Atributos")]
        public int vida;
        public float andarVelocidad;
        public float correrVelocidad;
        public Assets.Objeto[] objetosSueltaAlMorir;

        [Header("IA")]
        public IATipo iaTipo;
        public IAEstado iaEstado;
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
        private float ultimaVezAtaque;
        public float distanciaAtaque;

        private float distanciaJugador;

        [HideInInspector] public NavMeshAgent agente;
        private Animator animador;
        private SkinnedMeshRenderer[] meshRenderers;

        public void Awake()
        {
            agente = GetComponent<NavMeshAgent>();
            animador = GetComponentInChildren<Animator>();
            meshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
        }

        public void Start()
        {
            CambiarEstado(IAEstado.Deambulando);
        }

        public void Update()
        {
            distanciaJugador = Vector3.Distance(transform.position, Jugador.Movimientos.instancia.transform.position);

            if (iaEstado == IAEstado.Ausente)
            {
                animador.SetBool("moviendo", false);
            }
            else
            {
                animador.SetBool("moviendo", true);
            }
           
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
                agente.SetDestination(CalcularNuevaPosicionHuida());
            }
        }

        public void ActualizacionAtacando()
        {
            if (distanciaJugador > distanciaAtaque)
            {
                agente.isStopped = false;
                agente.SetDestination(Jugador.Movimientos.instancia.transform.position);
            }
            else
            {
                agente.isStopped = true;

                if (Time.time - ultimaVezAtaque > ataqueVelocidad)
                {
                    ultimaVezAtaque = Time.time;
                    Jugador.Movimientos.instancia.GetComponent<iDañable>().RecibirDaño(daño);
                    animador.SetTrigger("atacar");
                }
            }
        }

        public void ActualizacionHuyendo()
        {
            if (distanciaJugador < distanciaSeguridad && agente.remainingDistance < 0.1f)
            {
                agente.SetDestination(CalcularNuevaPosicionHuida());
            }
            else if (distanciaJugador > distanciaSeguridad)
            {
                CambiarEstado(IAEstado.Deambulando);
            }
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
                    agente.isStopped = false;
                    break;
                }

                case IAEstado.Huyendo:
                {
                    agente.speed = correrVelocidad;
                    agente.isStopped = false;
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
            agente.SetDestination(CalcularNuevaPosicionDeambulando());
        }

        public Vector3 CalcularNuevaPosicionDeambulando()
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

        public Vector3 CalcularNuevaPosicionHuida()
        {
            NavMeshHit hit;
            NavMesh.SamplePosition(transform.position + (Random.onUnitSphere * distanciaSeguridad), out hit, distanciaSeguridad, NavMesh.AllAreas);

            int i = 0;

            while (CalcularAngulo(hit.position) > 90 || distanciaJugador < distanciaSeguridad)
            {
                NavMesh.SamplePosition(transform.position + (Random.onUnitSphere * distanciaSeguridad), out hit, distanciaSeguridad, NavMesh.AllAreas);

                i += 1;

                if (i == 40)
                {
                    break;
                }
            }

            return hit.position;
        }

        public float CalcularAngulo(Vector3 objetivoPosicion)
        {
            return Vector3.Angle(transform.position - Jugador.Movimientos.instancia.transform.position, transform.position + objetivoPosicion);
        }

        public void RecibirDaño(int cantidad)
        {
            vida = vida - cantidad;

            if (vida <= 0)
            {
                Muerto();
            }

            StartCoroutine(DañoParpadeo());

            if (iaTipo == IATipo.Pasiva)
            {
                CambiarEstado(IAEstado.Huyendo);
            }
        }

        public void Muerto()
        {
            int i = 0;

            while (i < objetosSueltaAlMorir.Length)
            {
                Instantiate(objetosSueltaAlMorir[i].prefab, transform.position, Quaternion.identity);
                i += 1;
            }

            Destroy(gameObject);
        }

        public IEnumerator DañoParpadeo()
        {
            int i = 0;

            while (i < meshRenderers.Length)
            {
                meshRenderers[i].material.color = new Color(1, 0.6f, 0.6f);
                i += 1;
            }

            yield return new WaitForSeconds(0.1f);

            i = 0;

            while (i < meshRenderers.Length)
            {
                meshRenderers[i].material.color = Color.white;
                i += 1;
            }
        }
    }
}

