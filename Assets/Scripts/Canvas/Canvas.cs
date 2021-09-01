using UnityEngine;

namespace Canvas
{
    public class Canvas : MonoBehaviour
    {
        [Header("Canvas")]
        public GameObject juego;
        public GameObject inventario;
        public GameObject crafting;
        public GameObject construcciones;
        public GameObject mapa;

        [Header("Opciones")]
        public bool desarrollador;

        public static Canvas instancia;

        public void Awake()
        {
            instancia = this;
        }
    }
}

