using UnityEngine;

namespace Escenario
{
    public class Recurso : MonoBehaviour
    {
        public Assets.Objeto objetoADar;
        public int cantidadPorGolpe = 1;
        public int cantidad;
        public GameObject particulaGolpe;

        [Header("Generacion")]
        public float alturaMinima;
        public float alturaMaxima;
        public int porcentaje;

        private bool destruido;
        private int dias;

        public void Start()
        {
            destruido = false;

            if (DiaNoche.instancia != null)
            {
                dias = DiaNoche.instancia.dias;
            }
            else
            {
                dias = 1;
            }
        }

        public void Recolectar(Vector3 puntoGolpeo, Vector3 puntoNormal)
        {
            int i = 0;
            while (i < cantidadPorGolpe)
            {
                if (cantidad <= 0)
                {
                    break;
                }

                cantidad -= 1;

                Jugador.Inventario.Inventario.instancia.AñadirObjeto(objetoADar);
                i += 1;
            }

            Destroy(Instantiate(particulaGolpe, puntoGolpeo, Quaternion.LookRotation(puntoNormal, Vector3.up)), 1f);

            if (cantidad <= 0)
            {
                Destroy(gameObject);
                destruido = true;
            }
        }

        public void Update()
        {
            if (destruido == true)
            {
                if (dias != DiaNoche.instancia.dias)
                {

                }
            }

            dias = DiaNoche.instancia.dias;
        }
    }
}

