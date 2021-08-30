using UnityEngine;

namespace Canvas
{
    public class Canvas : MonoBehaviour
    {
        [Header("Canvas")]
        public GameObject juego;

        [Header("Opciones")]
        public bool desarrollador;

        public static Canvas instancia;

        public void Awake()
        {
            instancia = this;
        }
    }
}

