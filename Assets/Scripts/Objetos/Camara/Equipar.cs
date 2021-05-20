using UnityEngine;

namespace Objeto
{
    public class Equipar : Camara
    {
        [Header("Ataque")]
        public float velocidad;
        private bool atacando;
        public float maximaDistancia;

        [Header("Recursos")]
        public bool daRecurso;

        [Header("Combate")]
        public bool haceDaño;
        public int daño;

        private Animator animacion;
        private Camera cam;

        public void Awake()
        {
            animacion = GetComponent<Animator>();
            cam = Camera.main;
        }

        public override void AtacarInput()
        {
            if (atacando == false)
            {
                atacando = true;
                animacion.SetTrigger("Atacar");
                Invoke("PuedeAtacar", velocidad);
            }
        }

        public void PuedeAtacar()
        {
            atacando = false;
        }

        public void AlGolpear()
        {
            Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, maximaDistancia) == true)
            {
                if (daRecurso == true && hit.collider.GetComponent<Recurso>() != null)
                {
                    hit.collider.GetComponent<Recurso>().Recolectar(hit.point, hit.normal);
                }

                if (haceDaño == true && hit.collider.GetComponent<iDañable>() != null)
                {
                    hit.collider.GetComponent<iDañable>().RecibirDaño(daño);
                }
            }
        }
    }
}

