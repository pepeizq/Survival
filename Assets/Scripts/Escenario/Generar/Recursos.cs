using UnityEngine;

namespace Escenario.Generar
{
    public class Recursos : MonoBehaviour
    {
        public static Recursos instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Generar(Assets.Casilla[,] casillas)
        {
            for (int x = 0; x < casillas.GetLength(0); x++)
            {
                for (int z = 0; z < casillas.GetLength(1); z++)
                {
                    if (casillas[x, z] != null)
                    {
                        if (casillas[x, z].recursoPosible == true)
                        {
                            int azarPoner = Random.Range(0, 16 - (int)casillas[x, z].prefab.gameObject.transform.position.y);
                 
                            if (azarPoner > 6)
                            {
                                if (casillas[x, z].isla.recursos != null)
                                {
                                    if (casillas[x, z].isla.recursos.Length > 0)
                                    {
                                        int azarRecurso = Random.Range(0, casillas[x, z].isla.recursos.Length);
                                        GameObject recurso = casillas[x, z].isla.recursos[azarRecurso];

                                        GameObject recurso2 = Instantiate(recurso);
                                        recurso2.transform.SetParent(casillas[x, z].prefab.transform);

                                        Recurso recursoDatos = recurso2.GetComponent<Recurso>();
                                        recurso2.transform.localPosition = recursoDatos.posicionCasilla + casillas[x, z].recursoPosicion;

                                        int azarRotacion = Random.Range(0, 365);
                                        recurso2.gameObject.transform.Rotate(Vector3.up, azarRotacion, Space.World);
                                    }
                                }
                            }                          
                        }
                    }
                }
            }
        }
    }
}