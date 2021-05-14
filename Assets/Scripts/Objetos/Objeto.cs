using UnityEngine;

namespace Objeto
{
    public class Objeto : MonoBehaviour, IInteractuable
    {
        public Datos datos;

        public string MensajeDisponible()
        {
            return string.Format("Coge {0}", datos.nombre);
        }

        public void Interactuar()
        {
            Destroy(gameObject);
        }
    }
}

