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
                if (Jugador.Inventario.Inventario.instancia.TieneObjetos(receta.costes[i].objeto, receta.costes[i].cantidad) == false)
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
                //Canvas.Canvas.instancia.crafting.Craftear(receta);

                int i = 0;
                while (i < receta.costes.Length)
                {
                    int j = 0;
                    while (j < receta.costes[i].cantidad)
                    {
                        Jugador.Inventario.Inventario.instancia.QuitarObjeto(receta.costes[i].objeto);
                        j += 1;
                    }

                    i += 1;
                }

                Jugador.Inventario.Inventario.instancia.AñadirObjeto(receta.objetoACraftear);

                int k = 0;
                while (k < Canvas.Crafting.instancia.recetas.Length)
                {
                    Canvas.Crafting.instancia.recetas[k].ComprobarPuedeCraftear();

                    k += 1;
                }
            }
        }
    }
}

