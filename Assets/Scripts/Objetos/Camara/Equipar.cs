using UnityEngine;

namespace Objeto
{
    public class Equipar : Camara
    {
        public float ataqueVelocidad;
        private bool atacando;
        public float ataqueDistancia;

        [Header("Recursos")]
        public bool recolectaRecursos;

        [Header("Combate")]
        public bool haceDaño;
        public int daño;

        private Animator animacion;
        private Camera camara;

        public void Awake()
        {
            animacion = GetComponent<Animator>();
            camara = Camera.main;
        }

        public override void AtacarInput()
        {
            if (atacando == false)
            {
                atacando = true;
                animacion.SetTrigger("Atacar");
                Invoke("PuedeAtacar", ataqueVelocidad);
            }
        }

        public void PuedeAtacar()
        {
            atacando = true;
        }

        public void AlGolpear()
        {

        }
    }
}

