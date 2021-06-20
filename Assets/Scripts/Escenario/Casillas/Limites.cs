namespace Escenario.Casillas
{
    public static class Limites
    {
        public static bool Comprobar(int valor, int ajuste, int tamaño)
        {
            if ((valor - ajuste >= 0) && (valor + ajuste <= tamaño))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

