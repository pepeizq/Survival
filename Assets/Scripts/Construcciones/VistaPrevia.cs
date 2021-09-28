using System.Collections.Generic;
using UnityEngine;

namespace Construccion
{
    public class VistaPrevia : MonoBehaviour
    {
        public Material puedeConstruir;
        public Material noPuedeConstruir;
        private MeshRenderer[] meshRenderers;
        private List<GameObject> objetosColisiones = new List<GameObject>();
        
        public void Awake()
        {
            meshRenderers = transform.GetComponentsInChildren<MeshRenderer>();
        }

        public void PuedeColocar()
        {
            EstablecerMaterial(puedeConstruir);
        }

        public void NoPuedeColocar()
        {
            EstablecerMaterial(noPuedeConstruir);
        }

        private void EstablecerMaterial(Material material)
        {
            int i = 0;
            while (i < meshRenderers.Length)
            {
                Material[] materiales = new Material[meshRenderers[i].materials.Length];

                int j = 0;
                while (j < materiales.Length)
                {
                    materiales[j] = material;

                    j += 1;
                }

                meshRenderers[i].materials = materiales;

                i += 1;
            }
        }

        public bool ColisionandoConObjetos()
        {
            //int i = 0;
            //while (i < objetosColisiones.Count)
            //{
            //    if (objetosColisiones[i] == null)
            //    {
            //        objetosColisiones.RemoveAt(i);
            //    }

            //    i += 1;
            //}

            objetosColisiones.RemoveAll(x => x == null);

            if (objetosColisiones.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OnTriggerEnter(Collider colision)
        {
            //ID de la layer de terreno
            if (colision.gameObject.layer != 12)
            {
                objetosColisiones.Add(colision.gameObject);
            }           
        }

        public void OnTriggerExit(Collider colision)
        {
            if (colision.gameObject.layer != 12)
            {
                objetosColisiones.Remove(colision.gameObject);
            }
        }
    }
}

