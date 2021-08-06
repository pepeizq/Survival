using UnityEngine;

namespace Escenario.Generar
{
    public class Llano : MonoBehaviour
    {
        public static Llano instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Generar(Assets.Casilla[,] casillas, Assets.Isla[] islas)
        {
            for (int x = 0; x < casillas.GetLength(0); x++)
            {
                for (int z = 0; z < casillas.GetLength(1); z++)
                {
                    if (casillas[x, z] == null)
                    {
                        foreach (Assets.Isla isla in islas)
                        {
                            bool poner = true;

                            if (x < isla.coordenadasMinimas.x)
                            {
                                poner = false;
                            }
                            else if (z < isla.coordenadasMinimas.y)
                            {
                                poner = false;
                            }
                            else if (x > isla.coordenadasMinimas.x + isla.extensionMaxima.x)
                            {
                                poner = false;
                            }
                            else if (z > isla.coordenadasMinimas.y + isla.extensionMaxima.y)
                            {
                                poner = false;
                            }

                            //-----------------------------------------

                            bool azar = false;

                            if (x == isla.coordenadasMinimas.x - 1 && z >= isla.coordenadasMinimas.y && z <= isla.coordenadasMinimas.y + isla.extensionMaxima.y)
                            {
                                azar = true;
                            }
                            else if (x == isla.coordenadasMinimas.x + 1 && z >= isla.coordenadasMinimas.y && z <= isla.coordenadasMinimas.y + isla.extensionMaxima.y)
                            {
                                azar = true;
                            }
                            else if (z == isla.coordenadasMinimas.y - 1 && x >= isla.coordenadasMinimas.x && x <= isla.coordenadasMinimas.x + isla.extensionMaxima.x)
                            {
                                azar = true;
                            }
                            else if (z == isla.coordenadasMinimas.y + 1 && x >= isla.coordenadasMinimas.x && x <= isla.coordenadasMinimas.x + isla.extensionMaxima.x)
                            {
                                azar = true;
                            }

                            if (azar == true)
                            {
                                int numAzar = (int)Random.Range(0, 10);

                                if (numAzar > 3)
                                {
                                    poner = true;
                                }
                            }

                            //-----------------------------------------

                            if (poner == true)
                            {
                                Assets.Casilla plano = new Assets.Casilla(islas[isla.id].casillas[0].id, 0, new Vector3(x, 0.5f, z));
                                plano.isla = islas[isla.id];
                                Escenario.instancia.PonerCasilla(plano);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}