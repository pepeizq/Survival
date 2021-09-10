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

        [Header("Generacion")]
        public float alturaMinima;
        public float alturaMaxima;
        [Range(0, 100)]
        public int porcentaje;

        [Header("Subrecursos")]
        public List<GameObject> subrecursos;
        [Range(0, 100)]
        public int subrecursoGeneracion;

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
                if (subrecursos != null)
                {
                    foreach (GameObject subrecurso in subrecursos)
                    {
                        Rigidbody cuerpo = subrecurso.GetComponent<Rigidbody>();
                        cuerpo.isKinematic = false;
                        Instantiate(subrecurso, subrecurso.transform.position, Quaternion.Euler(Vector3.one * Random.value * 360.0f));
                    }
                }

                Destroy(gameObject);
            }
        }

        public void Update()
        {
            
        }
    }
}

