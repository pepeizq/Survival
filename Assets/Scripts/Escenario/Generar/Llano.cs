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

        public void Generar(Assets.Casilla[,] casillas, float altura)
        {
            Assets.Isla isla = null;
            int rango = 3;

            for (int x = 0; x < casillas.GetLength(0); x++)
            {
                for (int z = 0; z < casillas.GetLength(1); z++)
                {
                    if (casillas[x, z] == null)
                    {
                        bool poner = false;
                       
                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x - rango, z - rango);

                            if (poner == true)
                            {
                                isla = casillas[x - rango, z - rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x - rango, z);

                            if (poner == true)
                            {
                                isla = casillas[x - rango, z].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x, z - rango);

                            if (poner == true)
                            {
                                isla = casillas[x, z - rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x + rango, z - rango);

                            if (poner == true)
                            {
                                isla = casillas[x + rango, z - rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x - rango, z + rango);

                            if (poner == true)
                            {
                                isla = casillas[x - rango, z + rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x, z + rango);

                            if (poner == true)
                            {
                                isla = casillas[x, z + rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x + rango, z);

                            if (poner == true)
                            {
                                isla = casillas[x + rango, z].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x + rango, z + rango);

                            if (poner == true)
                            {
                                isla = casillas[x + rango, z + rango].isla;
                            }
                        }
              
                        if (poner == true)
                        {
                            Assets.Casilla plano = new Assets.Casilla(isla.casillas[0].id, 0, new Vector3(x, altura, z));
                            plano.isla = isla;
                            Escenario.instancia.PonerCasilla(plano);
                        }
                    }
                }
            }
        }

        private bool VerificarPoner(Assets.Casilla[,] casillas, int x, int z)
        {
            if (Limites.Comprobar(x, 2, Escenario.instancia.tamañoEscenarioX) == true && Limites.Comprobar(z, 2, Escenario.instancia.tamañoEscenarioZ) == true)
            {
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].posicion.y > 1f)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}