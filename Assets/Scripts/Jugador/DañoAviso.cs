using System.Collections;
using UnityEngine;

namespace Jugador
{
    public class DañoAviso : MonoBehaviour
    {
        public float velocidadParpadeo;

        private Coroutine desvanecer;

        public void Parpadeo()
        {
            if (desvanecer != null)
            {
                StopCoroutine(desvanecer);
            }

            Canvas.Juego.instancia.imagenDañoAviso.enabled = true;
            Canvas.Juego.instancia.imagenDañoAviso.color = Color.white;
            desvanecer = StartCoroutine(Desvanecer());
        }

        IEnumerator Desvanecer()
        {
            float alpha = 1f;

            while (alpha > 0)
            {
                alpha -= (1f / velocidadParpadeo) * Time.deltaTime;
                Canvas.Juego.instancia.imagenDañoAviso.color = new Color(1f, 1f, 1f, alpha);
                yield return null;
            }

            Canvas.Juego.instancia.imagenDañoAviso.enabled = false;
        }
    }
}