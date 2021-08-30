using TMPro;
using UnityEngine;

namespace Canvas
{
    public class Juego : MonoBehaviour
    {
        [Header("Modulo Desarrollador")]
        public GameObject desarrolladorCaja;
        public TextMeshProUGUI desarrolladorDatos;

        public static Juego instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Start()
        {
            if (Canvas.instancia.desarrollador == true)
            {
                desarrolladorCaja.SetActive(true);
            }
            else
            {
                desarrolladorCaja.SetActive(false);
            }
        }

        public void Update()
        {
            if (Canvas.instancia.desarrollador == true)
            {
                desarrolladorDatos.text = "test";
            }
                
        }
    }
}

