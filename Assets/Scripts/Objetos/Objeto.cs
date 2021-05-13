using UnityEngine;

public class Objeto : MonoBehaviour, IInteractuable
{
    public ObjetoDatos datos;

    public string MensajeDisponible()
    {
        return string.Format("Coge {0}", datos.nombre);
    }

    public void Interactuar()
    {
        Destroy(gameObject);
    }
}
