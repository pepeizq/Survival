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

        public void ActualizarPuedeCraftear()
        {
            puedeCraftear = true;

            int i = 0;
            while (i < receta.costes.Length)
            {
                if (Jugador.Inventario.instancia.TieneObjetos(receta.costes[i].objeto, receta.costes[i].cantidad) == true)
                {

                }

                i += 1;
            }
        }
    }
}

