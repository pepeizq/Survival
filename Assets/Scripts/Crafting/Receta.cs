using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Crafting
{
    public class Receta : MonoBehaviour
    {
        public Assets.Receta receta;
        public Image fondo;
        public Image icono;
        public TextMeshProUGUI nombre;
        public Image[] recursosCostes;

        public Color siPuedeCraftear;
        public Color noPuedeCraftear;

        private bool puedeCraftear;

        public void OnEnable()
        {
            ComprobarPuedeCraftear();
        }

        public void ComprobarPuedeCraftear()
        {
            puedeCraftear = true;

            int i = 0;
            while (i < receta.costes.Length)
            {
                if (Jugador.Inventario.instancia.TieneObjetos(receta.costes[i].objeto, receta.costes[i].cantidad) == false)
                {
                    puedeCraftear = false;
                    break;
                }

                i += 1;
            }

            if (puedeCraftear == true)
            {
                fondo.color = siPuedeCraftear;
            }
            else
            {
                fondo.color = noPuedeCraftear;
            }
        }

        public void Start()
        {
            icono.sprite = receta.objetoACraftear.icono;
            nombre.text = receta.objetoACraftear.nombre;

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
            if (puedeCraftear == true)
            {
                Ventana.instancia.Craftear(receta);
            }
        }
    }
}

