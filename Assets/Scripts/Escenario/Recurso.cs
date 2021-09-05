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

        [HideInInspector]
        private GameObject recursoTemporal;
        [HideInInspector]
        public int casillaX;
        [HideInInspector]
        public int casillaZ;

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

            recursoTemporal = gameObject;
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
            if (dias != DiaNoche.instancia.dias)
            {
                if (destruido == true)
                {
                    if (Generar.Escenario.instancia.casillas[casillaX, casillaZ] != null)
                    {
                        if (Generar.Escenario.instancia.casillas[casillaX, casillaZ].contruido == false)
                        {
                            Instantiate(recursoTemporal);
                            destruido = false;
                        }
                    }
                }

                dias = DiaNoche.instancia.dias;
            }
        }
    }
}

