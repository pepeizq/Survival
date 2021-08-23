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
                            int azarPoner = Random.Range(0, 9);

                            if (azarPoner > 6)
                            {
                                GameObject recurso = casillas[x, z].isla.recursos[0];

                                //casillas[x, z].prefab.gameObject.Instantiate(recurso);
                            }
                        }
                    }
                }
            }
        }
    }
}