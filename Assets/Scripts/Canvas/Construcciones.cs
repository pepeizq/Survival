using UnityEngine;

namespace Canvas
{
    public class Construcciones : MonoBehaviour
    {
        public void AlAbrirInventario()
        {
            Canvas.instancia.construcciones.SetActive(false);
        }

        public void OnEnable()
        {
            if (Jugador.Inventario.instancia != null)
            {
                Jugador.Inventario.instancia.abrirInventario.AddListener(AlAbrirInventario);
            }           
        }

        public void OnDisable()
        {
            if (Jugador.Inventario.instancia != null)
            {
                Jugador.Inventario.instancia.abrirInventario.RemoveListener(AlAbrirInventario);
            }            
        }
    }
}

