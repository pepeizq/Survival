using UnityEngine;

namespace Crafting
{
    public class Ventana : MonoBehaviour
    {
        public Receta[] recetas;
        public static Ventana instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void AlAbrirInventario()
        {

        }
    }
}

