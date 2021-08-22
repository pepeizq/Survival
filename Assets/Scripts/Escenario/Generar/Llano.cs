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

        public void Generar(Assets.Casilla[,] casillas, Assets.Isla[] islas, float altura)
        {
            for (int x = 0; x < casillas.GetLength(0); x++)
            {
                for (int z = 0; z < casillas.GetLength(1); z++)
                {
                    if (casillas[x, z] == null)
                    {
                        bool poner = false;
                        Assets.Isla isla = null;

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x - 3, z - 3);

                            if (poner == true)
                            {

                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x - 3, z);
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x, z - 3);
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x + 3, z - 3);
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x - 3, z + 3);
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x, z + 3);
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x + 3, z);
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x + 3, z + 3);
                        }
              

                        if (poner == true)
                        {
                            Assets.Casilla plano = new Assets.Casilla(islas[isla2.id].casillas[0].id, 0, new Vector3(x, altura, z));
                            plano.isla = islas[isla2.id];
                            Escenario.instancia.PonerCasilla(plano);
                            break;
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