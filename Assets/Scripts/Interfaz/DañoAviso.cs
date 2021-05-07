using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DañoAviso : MonoBehaviour
{
    public Image imagenAviso;
    public float velocidadParpadeo;

    private Coroutine desvanecer;

    public void Parpadeo()
    {
        if (desvanecer != null)
        {
            StopCoroutine(desvanecer);
        }

        imagenAviso.enabled = true;
        imagenAviso.color = Color.white;
        desvanecer = StartCoroutine(Desvanecer());
    }

    IEnumerator Desvanecer()
    {
        float alpha = 1f;

        while (alpha > 0)
        {
            alpha -= (1f / velocidadParpadeo) * Time.deltaTime;
            imagenAviso.color = new Color(1f, 1f, 1f, alpha);
            yield return null;
        }

        imagenAviso.enabled = false;
    }
}
