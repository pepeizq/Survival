using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Construccion
{
    public class Fogata : Construir, IInteractuable
    {
        public GameObject particulaFuego;
        public GameObject luz;
        private Vector3 luzPosicionInicial;
        private bool estaEncendida;

        [Header("Daño")]
        public int daño;
        public float dañoVelocidad;

        private List<iDañable> cosasDañar = new List<iDañable>();

        public void Start()
        {
            luzPosicionInicial = luz.transform.localPosition;
            StartCoroutine(HacerDaño());
        }

        IEnumerator HacerDaño()
        {
            while (true)
            {
                if (estaEncendida == true)
                {
                    foreach (iDañable cosa in cosasDañar)
                    {
                        cosa.RecibirDaño(daño);
                    }
                }

                yield return new WaitForSeconds(dañoVelocidad);
            }
        }

        public string MensajeMostrar()
        {
            if (estaEncendida == true)
            {
                return "Apagar";
            }
            else
            {
                return "Encender";
            }
        }

        public void Interactuar()
        {
            if (estaEncendida == true)
            {
                estaEncendida = false;
            }
            else
            {
                estaEncendida = true;
            }

            particulaFuego.SetActive(estaEncendida);
            luz.SetActive(estaEncendida);
        }

        public void Update()
        {
            if (estaEncendida == true)
            {
                float x = Mathf.PerlinNoise(Time.time * 3, 0) / 40;
                float z = Mathf.PerlinNoise(0, Time.time * 3) / 40;

                luz.transform.localPosition = luzPosicionInicial + new Vector3(x, 0, z);
            }
        }

        public void OnTriggerEnter(Collider colision)
        {
            if (colision.gameObject.GetComponent<iDañable>() != null)
            {
                cosasDañar.Add(colision.gameObject.GetComponent<iDañable>());
            }
        }

        public void OnTriggerExit(Collider colision)
        {
            if (colision.gameObject.GetComponent<iDañable>() != null)
            {
                cosasDañar.Remove(colision.gameObject.GetComponent<iDañable>());
            }
        }
    }
}

