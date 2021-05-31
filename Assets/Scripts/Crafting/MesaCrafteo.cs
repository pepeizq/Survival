using UnityEngine;

namespace Crafting
{
    public class MesaCrafteo : Construccion.Construir, IInteractuable
    {
        private Ventana ventanaCrafteo;
        private Jugador.Movimientos jugador;

        public void Start()
        {
            ventanaCrafteo = FindObjectOfType<Ventana>(true);
            jugador = FindObjectOfType<Jugador.Movimientos>();
        }

        public string MensajeMostrar()
        {
            return "Craftear";
        }

        public void Interactuar()
        {
            ventanaCrafteo.gameObject.SetActive(true);
            jugador.EnseñarCursor(true);
        }
    }
}