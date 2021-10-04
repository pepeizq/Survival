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
        private float rotacionLibreEjeY = 0;
        public bool puedeRotar;
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
            rotacionLibreEjeY = 0;
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
                    if (puedeRotar == true)
                    {
                        rotacionLibreEjeY = rotacionLibreEjeY + rotacionVelocidad * Time.deltaTime;

                        if (rotacionLibreEjeY > 360)
                        {
                            rotacionLibreEjeY = 0;
                        }
                    }

                    if (Time.time - ultimaUbicacionTiempo > ubicacionActualizacionVelocidad)
                    {
                        ultimaUbicacionTiempo = Time.time;

                        Ray ray = camara.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                        RaycastHit hit;
                     
                        if (Physics.Raycast(ray, out hit, ubicacionMaximaDistancia, ubicacionLayerMask) == true)
                        {
                            vistaPrevia.transform.position = hit.point;
                            vistaPrevia.transform.up = hit.normal;                        
                            vistaPrevia.transform.Rotate(new Vector3(0, rotacionLibreEjeY, 0), Space.Self);

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
                            GameObject casilla = hit.collider.gameObject;
                
                            if (casilla != null)
                            {                         
                                Assets.Casilla casilla2 = Escenario.Generar.Escenario.instancia.casillas[(int)casilla.transform.position.x, (int)casilla.transform.position.z];

                                if (casilla2 != null)
                                {
                                    if (casilla2.construccionPosible == true)
                                    {
                                        if (casilla2.posicionesSuelo != null)
                                        {
                                            if (casilla2.posicionesSuelo.Count > 0)
                                            {
                                                if (casilla2.pisos != null)
                                                {
                                                    if (casilla2.pisos.Count == 0)
                                                    {
                                                        Vector3 posicion = casilla2.posicionesSuelo[0];

                                                        vistaPrevia.transform.position = posicion;
                                                        vistaPrevia.transform.up = hit.normal;
                                                        vistaPrevia.transform.SetParent(casilla2.prefab.transform);

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
                                                    else
                                                    {

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
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

        public void RotarInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Started)
            {
                instancia.puedeRotar = true;
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                instancia.puedeRotar = false;
            }
        }
    }
}

