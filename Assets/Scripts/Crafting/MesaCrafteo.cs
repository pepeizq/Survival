namespace Crafting
{
    public class MesaCrafteo : Construccion.Propiedades, IInteractuable
    {
        private Jugador.Movimientos jugador;

        public void Start()
        {
            jugador = FindObjectOfType<Jugador.Movimientos>();
        }

        public string MensajeMostrar()
        {
            return "Craftear";
        }

        public void Interactuar()
        {
            Canvas.Canvas.instancia.crafting.gameObject.SetActive(true);
            jugador.EnseñarCursor(true);
        }
    }
}