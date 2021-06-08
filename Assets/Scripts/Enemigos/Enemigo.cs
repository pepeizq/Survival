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
        public float ataqueDistancia;

        private float jugadorDistancia;

        private NavMeshAgent agente;
        private Animator animador;
        private SkinnedMeshRenderer[] meshRenderers;

        public void Awake()
        {
            
        }
    }
}

