using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    public class KitConstruccion : Objeto.Camara
    {
        private Assets.Construccion actualReceta;
        private Construccion.VistaPrevia vistaPrevia;

        public float ubicacionActualizacionVelocidad = 0.03f;
        private float ultimaUbicacionTiempo;
        public float ubicacionMaximaDistancia = 5;

        public LayerMask ubicacionLayerMask;

        public Vector3 ubicacionPosicion;
        private bool puedeUbicarConstruccion;
        private float rotacionEjeY;

        public float rotacionVelocidad = 180;

        private Camera camara;

        public static KitConstruccion instancia;

        public void Awake()
        {
            instancia = this;
            camara = Camera.main;
        }

        public override void AtacarInput()
        {
            if (actualReceta == null || vistaPrevia == null || puedeUbicarConstruccion == false)
            {
                return;
            }

            Instantiate(actualReceta.prefab, vistaPrevia.transform.position, vistaPrevia.transform.rotation);

            int i = 0;
            while (i < actualReceta.costes.Length)
            {
                int j = 0;
                while (j < actualReceta.costes[i].cantidad)
                {
                    Inventario.Inventario.instancia.QuitarObjeto(actualReceta.costes[i].objeto);
                    j += 1;
                }

                i += 1;
            }

            actualReceta = null;
            Destroy(vistaPrevia.gameObject);
            vistaPrevia = null;
            puedeUbicarConstruccion = false;
            rotacionEjeY = 0;
        }

        public override void Atacar2Input()
        {
            if (vistaPrevia != null)
            {
                Destroy(vistaPrevia.gameObject);
            }

            Canvas.Canvas.instancia.construcciones.SetActive(true);
            Movimientos.instancia.EnseñarCursor(true); 
        }

        public void EstablecerNuevaRecetaConstruccion(Assets.Construccion receta)
        {
            actualReceta = receta;
            Canvas.Canvas.instancia.construcciones.SetActive(false);
            Movimientos.instancia.EnseñarCursor(false);

            if (receta.tipo == Assets.Tipos.Construccion.Libre)
            {
                vistaPrevia = Instantiate(receta.vistaPreviaPrefab.gameObject).GetComponent<Construccion.VistaPrevia>();
            }
            
        }

        public void Update()
        {
            if (actualReceta != null && vistaPrevia != null && Time.time - ultimaUbicacionTiempo > ubicacionActualizacionVelocidad)
            {
                ultimaUbicacionTiempo = Time.time;

                Ray ray = camara.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, ubicacionMaximaDistancia, ubicacionLayerMask) == true)
                {
                    vistaPrevia.transform.position = hit.point;
                    vistaPrevia.transform.up = hit.normal;
                    vistaPrevia.transform.Rotate(new Vector3(0, rotacionEjeY, 0), Space.Self);

                    if (vistaPrevia.ColisionandoConObjetos() == false)
                    {
                        if (puedeUbicarConstruccion == false)
                        {
                            vistaPrevia.PuedeColocar();
                        }

                        puedeUbicarConstruccion = true;
                    }
                    else
                    {
                        if (puedeUbicarConstruccion == true)
                        {
                            vistaPrevia.NoPuedeColocar();
                        }

                        puedeUbicarConstruccion = false;
                    }
                }
            }

            if (Keyboard.current.rKey.isPressed == true)
            {
                rotacionEjeY = rotacionEjeY + rotacionVelocidad * Time.deltaTime;

                if (rotacionEjeY > 360)
                {
                    rotacionEjeY = 0;
                }
            }
        }

        public void OnDestroy()
        {
            if (vistaPrevia != null)
            {
                Destroy(vistaPrevia.gameObject);
            }
        }
    }
}

