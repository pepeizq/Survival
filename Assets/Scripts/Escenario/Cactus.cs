using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public int daño;
    public float dañoRate;

    //jugador o enemigos
    private List<iDañable> cosasDañar = new List<iDañable>();

    public void Start()
    {
        StartCoroutine(ManejarDaño());
    }

    IEnumerator ManejarDaño()
    {
        while(true)
        {
            foreach(iDañable cosa in cosasDañar)
            {
                cosa.RecibirDaño(daño);
            }

            yield return new WaitForSeconds(dañoRate);
        }
    }

    private void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.GetComponent<iDañable>() != null)
        {
            cosasDañar.Add(colision.gameObject.GetComponent<iDañable>());
        }
    }

    private void OnCollisionExit(Collision colision)
    {
        if (colision.gameObject.GetComponent<iDañable>() != null)
        {
            cosasDañar.Remove(colision.gameObject.GetComponent<iDañable>());
        }
    }
}
