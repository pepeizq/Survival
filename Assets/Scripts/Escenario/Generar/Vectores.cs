using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Escenario.Generar
{
    public class Vectores : MonoBehaviour
    {
        public static Vectores instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void GenerarCasillas(Assets.Casilla[,] casillas, Assets.Isla[] islas, int limitesMapa)
        {
            LimpiarDatos(islas);

            foreach (Assets.Isla isla in islas)
            {
                List<Vector3> listado = new List<Vector3>();

                int montañasGenerar = (int)isla.extensionMaxima.x / 10 * (int)isla.extensionMaxima.y / 10;
                int intentosGeneracion = montañasGenerar;

                int i = 1;
                while (i <= intentosGeneracion)
                {
                    float alturaCasilla = (int)Random.Range(3, isla.alturaMaxima);

                    int posicionX = (int)Random.Range((int)isla.coordenadasMinimas.x + limitesMapa, (int)isla.coordenadasMinimas.x + (int)isla.extensionMaxima.x - limitesMapa);
                    int posicionZ = (int)Random.Range((int)isla.coordenadasMinimas.y + limitesMapa, (int)isla.coordenadasMinimas.y + (int)isla.extensionMaxima.y - limitesMapa);

                    bool añadir = true;

                    foreach (Assets.Casilla casilla in casillas)
                    {
                        if (casilla != null)
                        {
                            if (Enumerable.Range((int)(casilla.posicion.x - alturaCasilla), (int)(casilla.posicion.x + alturaCasilla)).Contains(posicionX))
                            {
                                if (Enumerable.Range((int)(casilla.posicion.z - alturaCasilla), (int)(casilla.posicion.z + alturaCasilla)).Contains(posicionZ))
                                {
                                    añadir = false;

                                    if (intentosGeneracion >= 0)
                                    {
                                        intentosGeneracion -= 1;
                                        i -= 1;
                                    }
                                }
                            }
                        }
                    }

                    if (Limites.Comprobar(posicionX, 2, Escenario.instancia.tamañoEscenarioX) == false || Limites.Comprobar(posicionZ, 2, Escenario.instancia.tamañoEscenarioZ) == false)
                    {
                        añadir = false;
                    }

                    if (añadir == true)
                    {
                        listado.Add(new Vector3(posicionX, alturaCasilla, posicionZ));

                        int desplazamiento = 0;
                        while (alturaCasilla >= 1)
                        {
                            int planos = (int)Random.Range(0, 4 + desplazamiento);

                            if (desplazamiento > 0)
                            {
                                int j = 0;
                                while (j <= planos)
                                {
                                    int x = 0;
                                    int z = 0;

                                    int azar = (int)Random.Range(0, 12);

                                    if (azar == 1)
                                    {
                                        x = 1 + (int)(desplazamiento * 2);
                                        z = 1 + (int)(desplazamiento * 2);
                                    }
                                    else if (azar == 2)
                                    {
                                        x = 1 + (int)(desplazamiento * 2);
                                        z = -1 - (int)(desplazamiento * 2);
                                    }
                                    else if (azar == 3)
                                    {
                                        x = -1 - (int)(desplazamiento * 2);
                                        z = 1 + (int)(desplazamiento * 2);
                                    }
                                    else if (azar == 4)
                                    {
                                        x = -1 - (int)(desplazamiento * 2);
                                        z = -1 - (int)(desplazamiento * 2);
                                    }
                                    else if (azar == 5 || azar == 6)
                                    {
                                        x = 2 + (int)(desplazamiento * 2);
                                        z = Random.Range(-desplazamiento, desplazamiento);
                                    }
                                    else if (azar == 7 || azar == 8)
                                    {
                                        x = -2 - (int)(desplazamiento * 2);
                                        z = Random.Range(-desplazamiento, desplazamiento);
                                    }
                                    else if (azar == 9 || azar == 10)
                                    {
                                        x = Random.Range(-desplazamiento, desplazamiento);
                                        z = 2 + (int)(desplazamiento * 2);
                                    }
                                    else if (azar == 11 || azar == 12)
                                    {
                                        x = Random.Range(-desplazamiento, desplazamiento);
                                        z = -2 - (int)(desplazamiento * 2);
                                    }

                                    if (azar > 0)
                                    {
                                        if (alturaCasilla == 1.5f || alturaCasilla == 2f)
                                        {
                                            for (int origenX = posicionX + x - 1; origenX < posicionX + x + 2; origenX++)
                                            {
                                                for (int origenZ = posicionZ + z - 1; origenZ < posicionZ + z + 2; origenZ++)
                                                {
                                                    if (Limites.Comprobar(origenX, 2, (int)isla.extensionMaxima.x) == true && Limites.Comprobar(origenZ, 2, (int)isla.extensionMaxima.y) == true)
                                                    {
                                                        if (casillas[origenX, origenZ] == null)
                                                        {
                                                            listado.Add(new Vector3(origenX, alturaCasilla, origenZ));
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else if (alturaCasilla == 1f)
                                        {
                                            for (int origenX = posicionX + x - 2; origenX < posicionX + x + 3; origenX++)
                                            {
                                                for (int origenZ = posicionZ + z - 2; origenZ < posicionZ + z + 3; origenZ++)
                                                {
                                                    if (Limites.Comprobar(origenX, 2, (int)isla.extensionMaxima.x) == true && Limites.Comprobar(origenZ, 2, (int)isla.extensionMaxima.y) == true)
                                                    {
                                                        if (casillas[origenX, origenZ] == null)
                                                        {
                                                            listado.Add(new Vector3(origenX, alturaCasilla, origenZ));
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (Limites.Comprobar(posicionX + x, 2, (int)isla.extensionMaxima.x) == true && Limites.Comprobar(posicionZ + z, 2, (int)isla.extensionMaxima.y) == true)
                                            {
                                                listado.Add(new Vector3(posicionX + x, alturaCasilla, posicionZ + z));
                                            }
                                        }
                                    }

                                    j += 1;
                                }
                            }

                            alturaCasilla -= 0.5f;
                            desplazamiento += 1;
                        }
                    }                   

                    i += 1;
                }

                CopiarDatos(listado, isla.id);
            }
        }

        private void LimpiarDatos(Assets.Isla[] islas)
        {
            foreach (Assets.Isla isla in islas)
            {
                PlayerPrefs.SetString("isla" + isla.id.ToString(), null);
            }
        }

        private void CopiarDatos(List<Vector3> listado, int id)
        {
            Partida.PartidaIsla isla = new Partida.PartidaIsla
            {
                id = id,
                casillas = new Partida.PartidaCasilla[listado.Count]
            };

            int i = 0;
            while (i < isla.casillas.Length)
            {
                isla.casillas[i] = new Partida.PartidaCasilla
                {
                    coordenadas = new Partida.VectorTres(listado[i])
                };

                i += 1;
            }

            string datos = JsonUtility.ToJson(isla);
            PlayerPrefs.SetString("vectoresIsla" + isla.id.ToString(), datos);
        }

        public Partida.PartidaIsla LeerDatos(int id)
        {
            Partida.PartidaIsla isla = JsonUtility.FromJson<Partida.PartidaIsla>(PlayerPrefs.GetString("vectoresIsla" + id.ToString()));
            return isla;
        }
    }
}