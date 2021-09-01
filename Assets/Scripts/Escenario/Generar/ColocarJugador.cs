using UnityEngine;

namespace Escenario.Generar
{
    public class ColocarJugador : MonoBehaviour
    {
        public static ColocarJugador instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Generar(Assets.Casilla[,] casillas, Assets.Isla islaCero, Assets.Objeto[] herramientas)
        {
            int x = ((int)islaCero.coordenadasMinimas.x + (int)islaCero.extensionMaxima.x) / 2;
            int z = ((int)islaCero.coordenadasMinimas.y + (int)islaCero.extensionMaxima.y) / 2;

            if (casillas[x, z] != null)
            {
                Vector3 posicion = casillas[x, z].prefab.gameObject.transform.position;
                casillas[x, z].recursoPosible = false;

                if (casillas[x, z].id != 0)
                {
                    posicion.y = posicion.y + 1f;
                }

                Jugador.Movimientos.instancia.transform.position = posicion;
            }

            if (herramientas != null)
            {
                if (herramientas.Length > 0)
                {
                    int i = 0;
                    while (i < herramientas.Length)
                    {
                        float altura = casillas[x, z].prefab.gameObject.transform.position.y;
                        Vector3 posicionColocar = new Vector3(x, altura + 1f, z);

                        if (casillas[x, z].id != 0)
                        {
                            posicionColocar.y = posicionColocar.y + 1f;
                        }

                        Instantiate(herramientas[i].prefab, posicionColocar, Quaternion.identity);
                        casillas[x, z].recursoPosible = false;

                        i += 1;
                    }
                }
            }
        }
    }
}