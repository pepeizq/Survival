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
                        Jugador.Inventario.Inventario.instancia.AñadirObjeto(herramientas[i]);

                        if (i == 0)
                        {
                            Jugador.Inventario.Inventario.instancia.SeleccionarObjeto(i);
                            Jugador.Inventario.Inventario.instancia.EquiparBoton(true);
                        }

                        i += 1;
                    }
                }
            }
        }
    }
}