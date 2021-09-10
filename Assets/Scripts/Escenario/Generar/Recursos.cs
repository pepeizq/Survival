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
                        if (casillas[x, z].recursoPosible == true && casillas[x, z].construido == false)
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

                                        casillas[x, z].recurso = recursoFinal;
                                        casillas[x, z].recursoID = azarRecurso;
                                        casillas[x, z].recursoPuesto = true;

                                        if (recursoTemp.subrecursos != null)
                                        {
                                            MostrarSubrecursos(recursoTemp);
                                        }
                                    }                                   
                                }
                            }
                        }
                    }
                }
            }
        }

        public void Comprobar()
        {
            for (int x = 0; x < Escenario.instancia.casillas.GetLength(0); x++)
            {
                for (int z = 0; z < Escenario.instancia.casillas.GetLength(1); z++)
                {
                    if (Escenario.instancia.casillas[x, z] != null)
                    {
                        if (Escenario.instancia.casillas[x, z].recursoPuesto == true && Escenario.instancia.casillas[x, z].construido == false)
                        {
                            if (Escenario.instancia.casillas[x, z].recurso == null)
                            {
                                int azarPoner = Random.Range(0, 100);

                                if (azarPoner >= 50)
                                {
                                    GameObject recursoFinal = Instantiate(Escenario.instancia.casillas[x, z].isla.recursos[Escenario.instancia.casillas[x, z].recursoID]);
                                    recursoFinal.transform.SetParent(Escenario.instancia.casillas[x, z].prefab.transform);
                                    recursoFinal.transform.localPosition = Escenario.instancia.casillas[x, z].recursoPosicion;

                                    int azarRotacion = Random.Range(0, 365);
                                    recursoFinal.gameObject.transform.Rotate(Vector3.up, azarRotacion, Space.World);

                                    Recurso recursoTemp = recursoFinal.GetComponent<Recurso>();

                                    if (recursoTemp.subrecursos != null)
                                    {
                                        MostrarSubrecursos(recursoTemp);
                                    }
                                }                               
                            }                          
                        }
                    }
                }
            }
        }

        private void MostrarSubrecursos(Recurso recurso)
        {
            foreach (GameObject subrecurso in recurso.subrecursos)
            {
                if (subrecurso != null)
                {
                    int azar = Random.Range(0, 100);

                    if (azar < recurso.subrecursoGeneracion)
                    {
                        Rigidbody cuerpo = subrecurso.GetComponent<Rigidbody>();
                        cuerpo.isKinematic = true;

                        subrecurso.SetActive(true);
                    }
                    else
                    {
                        subrecurso.SetActive(false);
                    }
                }
            }
        }
    }
}