using UnityEngine;

namespace Objeto
{
    public class Objeto : MonoBehaviour, IInteractuable
    {
        public Assets.Objeto objeto;

        public string MensajeMostrar()
        {
            return string.Format("Coge {0}", objeto.nombre);
        }

        public void Interactuar()
        {
            Jugador.Inventario.Inventario.instancia.AñadirObjeto(objeto);

            Destroy(gameObject);
        }
    }
}

