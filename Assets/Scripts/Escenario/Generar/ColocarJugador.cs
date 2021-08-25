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

        public void Generar(Assets.Casilla[,] casillas, Assets.Isla islaCero)
        {
            int x = ((int)islaCero.coordenadasMinimas.x + (int)islaCero.extensionMaxima.x) / 2;
            int z = ((int)islaCero.coordenadasMinimas.y + (int)islaCero.extensionMaxima.y) / 2;

            if (casillas[x, z] != null)
            {
                Vector3 posicion = casillas[x, z].prefab.gameObject.transform.position;
                casillas[x, z].recursoPosible = false;
                Jugador.Movimientos.instancia.transform.position = posicion;
            }
        }
    }
}