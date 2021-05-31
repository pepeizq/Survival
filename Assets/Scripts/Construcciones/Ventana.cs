using UnityEngine;

namespace Construccion
{
    public class Ventana : MonoBehaviour
    {
        public void AlAbrirInventario()
        {
            gameObject.SetActive(false);
        }

        public void OnEnable()
        {
            Jugador.Inventario.instancia.abrirInventario.AddListener(AlAbrirInventario);
        }

        public void OnDisable()
        {
            Jugador.Inventario.instancia.abrirInventario.RemoveListener(AlAbrirInventario);
        }
    }
}

