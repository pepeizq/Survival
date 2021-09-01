using System;
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
                if (Jugador.Movimientos.instancia != null)
                {
                    desarrolladorDatos.text = string.Format("x:{0} z:{1} altura: {2}",
                                                Math.Round(Jugador.Movimientos.instancia.transform.position.x, 0).ToString(),
                                                Math.Round(Jugador.Movimientos.instancia.transform.position.z, 0).ToString(),
                                                Math.Round(Jugador.Movimientos.instancia.transform.position.y, 1).ToString());
                }
            }              
        }
    }
}

