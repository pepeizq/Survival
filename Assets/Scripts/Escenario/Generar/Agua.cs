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

        public void Generar(Assets.Casilla[,] casillas, Assets.Isla[] islas)
        {
            for (int x = 0; x < casillas.GetLength(0); x++)
            {
                for (int z = 0; z < casillas.GetLength(1); z++)
                {
                    if (casillas[x, z] == null)
                    {

                    }
                }
            }
        }
    }
}

