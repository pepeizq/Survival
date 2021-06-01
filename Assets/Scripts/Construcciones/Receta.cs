using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Construccion
{
    public class Receta : MonoBehaviour
    {
        public Assets.Construccion receta;
        public Image fondo;
        public Image icono;
        public TextMeshProUGUI nombre;
        public Image[] recursosCostes;

        public Color siPuedeConstruir;
        public Color noPuedeConstruir;

        private bool puedeConstruir;

        public void OnEnable()
        {
            ComprobarPuedeConstruir();
        }

        public void ComprobarPuedeConstruir()
        {
            puedeConstruir = true;

            int i = 0;
            while (i < receta.costes.Length)
            {
                if (Jugador.Inventario.instancia.TieneObjetos(receta.costes[i].objeto, receta.costes[i].cantidad) == false)
                {
                    puedeConstruir = false;
                    break;
                }

                i += 1;
            }

            if (puedeConstruir == true)
            {
                fondo.color = siPuedeConstruir;
            }
            else
            {
                fondo.color = noPuedeConstruir;
            }
        }

        public void Start()
        {
            icono.sprite = receta.icono;
            nombre.text = receta.nombre;

            int i = 0;
            while (i < recursosCostes.Length)
            {
                if (i < receta.costes.Length)
                {
                    recursosCostes[i].gameObject.SetActive(true);
                    recursosCostes[i].sprite = receta.costes[i].objeto.icono;
                    recursosCostes[i].transform.GetComponentInChildren<TextMeshProUGUI>().text = receta.costes[i].cantidad.ToString();
                }
                else
                {
                    recursosCostes[i].gameObject.SetActive(false);
                }

                i += 1;
            }
        }

        public void BotonClick()
        {
            if (puedeConstruir == true)
            {
                Jugador.KitConstruccion.instancia.EstablecerNuevaRecetaConstruccion(receta);
            }
            else
            {
                Jugador.Movimientos.instancia.EnseñarCursor(false);
                Jugador.KitConstruccion.instancia.ventana.SetActive(false);
            }
        }
    }
}