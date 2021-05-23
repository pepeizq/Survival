using UnityEngine;

namespace Objeto
{
    public class Objeto : MonoBehaviour, IInteractuable
    {
        public Assets.Objeto objeto;

        public string MensajeDisponible()
        {
            return string.Format("Coge {0}", objeto.nombre);
        }

        public void Interactuar()
        {
            Jugador.Inventario.instancia.AñadirObjeto(objeto);

            Destroy(gameObject);
        }
    }
}

