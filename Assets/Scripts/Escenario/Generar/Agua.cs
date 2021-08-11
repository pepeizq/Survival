using UnityEngine;

namespace Escenario.Generar
{
    public class Agua : MonoBehaviour
    {
        public static Agua instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Generar(Assets.Casilla[,] casillas, float altura)
        {
            for (int x = 0; x < casillas.GetLength(0); x++)
            {
                for (int z = 0; z < casillas.GetLength(1); z++)
                {
                    if (casillas[x, z] == null)
                    {
                        if (casillas[x - 1, z] != null)
                        {
                            Assets.Isla isla = casillas[x - 1, z].isla;
                        }

                        Assets.Casilla plano = new Assets.Casilla(Escenario.instancia.casillasDebug.Length - 1, 0, new Vector3(x, altura, z));
                        Escenario.instancia.PonerCasilla(plano);
                    }
                }
            }
        }
    }
}

