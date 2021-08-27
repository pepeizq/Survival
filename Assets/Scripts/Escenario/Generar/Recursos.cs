using System.Collections.Generic;
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
                            if (casillas[x, z].isla.recursos != null)
                            {
                                if (casillas[x, z].isla.recursos.Length > 0)
                                {
                                    float alturaCasilla = casillas[x, z].posicion.y;
                                    List<GameObject> recursosIsla = new List<GameObject>();

                                    foreach (GameObject recursoIsla in casillas[x, z].isla.recursos)
                                    {
                                        Recurso recursoIslaDatos = recursoIsla.GetComponent<Recurso>();

                                        if (alturaCasilla >= recursoIslaDatos.alturaMinima && alturaCasilla <= recursoIslaDatos.alturaMaxima)
                                        {
                                            recursosIsla.Add(recursoIsla);
                                        }
                                    }

                                    int azarRecurso = Random.Range(0, recursosIsla.Count);
                                    Recurso recursoTemp = recursosIsla[azarRecurso].GetComponent<Recurso>();

                                    int azarPoner = Random.Range(0, 100 + (int)alturaCasilla * 20);

                                    if (azarPoner <= recursoTemp.porcentaje)
                                    {
                                        GameObject recursoFinal = Instantiate(recursosIsla[azarRecurso]);
                                        recursoFinal.transform.SetParent(casillas[x, z].prefab.transform);
                                        recursoFinal.transform.localPosition = casillas[x, z].recursoPosicion;

                                        int azarRotacion = Random.Range(0, 365);
                                        recursoFinal.gameObject.transform.Rotate(Vector3.up, azarRotacion, Space.World);
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