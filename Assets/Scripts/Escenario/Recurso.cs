using System.Collections.Generic;
using UnityEngine;

namespace Escenario
{
    public class Recurso : MonoBehaviour
    {
        public Assets.Objeto objetoADar;
        public int cantidadPorGolpe = 1;
        public int cantidad;
        public GameObject particulaGolpe;

        public List<GameObject> subrecursos;

        [Header("Generacion")]
        public float alturaMinima;
        public float alturaMaxima;
        public int porcentaje;

        public void Start()
        {

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
            }
        }

        public void Update()
        {
            
        }
    }
}

