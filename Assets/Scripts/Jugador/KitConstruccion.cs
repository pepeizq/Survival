using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    public class KitConstruccion : Objeto.Camara
    {
        private Assets.Construccion recetaConstruccion;
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
            if (recetaConstruccion == null || vistaPrevia == null || puedeUbicarConstruccion == false)
            {
                return;
            }

            Instantiate(recetaConstruccion.prefab, vistaPrevia.transform.position, vistaPrevia.transform.rotation);

            int i = 0;
            while (i < recetaConstruccion.costes.Length)
            {
                int j = 0;
                while (j < recetaConstruccion.costes[i].cantidad)
                {
                    Inventario.Inventario.instancia.QuitarObjeto(recetaConstruccion.costes[i].objeto);
                    j += 1;
                }

                i += 1;
            }

            recetaConstruccion = null;
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

        public void EstablecerNuevaRecetaConstruccion(Assets.Construccion nuevaReceta)
        {
            recetaConstruccion = nuevaReceta;
            Canvas.Canvas.instancia.construcciones.SetActive(false);
            Movimientos.instancia.EnseñarCursor(false);

            vistaPrevia = Instantiate(nuevaReceta.vistaPreviaPrefab.gameObject).GetComponent<Construccion.VistaPrevia>();
        }

        public void Update()
        {
            if (vistaPrevia != null && recetaConstruccion != null)
            {
                if (recetaConstruccion.tipo == Assets.Tipos.Construccion.Libre)
                {
                    if (Time.time - ultimaUbicacionTiempo > ubicacionActualizacionVelocidad)
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
                else if (recetaConstruccion.tipo == Assets.Tipos.Construccion.Suelo)
                {
                    if (Time.time - ultimaUbicacionTiempo > ubicacionActualizacionVelocidad)
                    {
                        ultimaUbicacionTiempo = Time.time;

                        Ray ray = camara.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                        RaycastHit hit;

                        if (Physics.Raycast(ray, out hit, ubicacionMaximaDistancia, ubicacionLayerMask) == true)
                        {

                        }
                    }
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

