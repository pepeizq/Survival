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

        [Header("Da�o")]
        public int da�o;
        public float da�oVelocidad;

        private List<iDa�able> cosasDa�ar = new List<iDa�able>();

        public void Start()
        {
            luzPosicionInicial = luz.transform.localPosition;
            StartCoroutine(HacerDa�o());
        }

        IEnumerator HacerDa�o()
        {
            while (true)
            {
                if (estaEncendida == true)
                {
                    foreach (iDa�able cosa in cosasDa�ar)
                    {
                        cosa.RecibirDa�o(da�o);
                    }
                }

                yield return new WaitForSeconds(da�oVelocidad);
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
            if (colision.gameObject.GetComponent<iDa�able>() != null)
            {
                cosasDa�ar.Add(colision.gameObject.GetComponent<iDa�able>());
            }
        }

        public void OnTriggerExit(Collider colision)
        {
            if (colision.gameObject.GetComponent<iDa�able>() != null)
            {
                cosasDa�ar.Remove(colision.gameObject.GetComponent<iDa�able>());
            }
        }
    }
}

