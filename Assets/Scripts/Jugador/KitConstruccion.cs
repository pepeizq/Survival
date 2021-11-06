using Escenario.Generar;
using System.Collections.Generic;
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

            GameObject objetoConstruir = recetaConstruccion.prefab;
            Vector3 coordenadas = vistaPrevia.transform.position;

            if (vistaPrevia != null)
            {
                if (recetaConstruccion.tipo == Assets.Tipos.Construccion.Suelo || recetaConstruccion.tipo == Assets.Tipos.Construccion.Pared)
                {
                    Coordenadas coordenadas2 = vistaPrevia.gameObject.GetComponent<Coordenadas>();

                    if (coordenadas2 != null)
                    {
                        Assets.Casilla casilla = Escenario.Generar.Escenario.instancia.casillas[coordenadas2.x, coordenadas2.z];

                        if (casilla != null)
                        {
                            if (recetaConstruccion.tipo == Assets.Tipos.Construccion.Suelo)
                            {
                                if (casilla.pisos == null)
                                {
                                    casilla.pisos = new List<Assets.Piso>();
                                }

                                Assets.Piso piso = new Assets.Piso();
                                piso.suelo = recetaConstruccion.prefab;

                                casilla.pisos.Add(piso);
                            }
                            else if (recetaConstruccion.tipo == Assets.Tipos.Construccion.Pared)
                            {
                                if (casilla.pisos != null)
                                {
                                    if (casilla.pisos.Count > 0)
                                    {
                                        Assets.Piso piso = casilla.pisos[casilla.pisos.Count - 1];
                                        piso.pared = recetaConstruccion.prefab;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            Instantiate(objetoConstruir, coordenadas, vistaPrevia.transform.rotation);

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

        public void MostrarVistaPreviaReceta(Assets.Construccion nuevaReceta)
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

                            VistaPreviaUbicar(vistaPrevia);
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
                            GameObject objeto = hit.collider.gameObject;
                           
                            if (objeto != null)
                            {
                                Assets.Casilla casilla = null;
                                int x = 0;
                                int z = 0;

                                if (objeto.GetComponent<Coordenadas>() != null)
                                {
                                    Coordenadas coordenadas = objeto.GetComponent<Coordenadas>();
                                    x = coordenadas.x;
                                    z = coordenadas.z;
                                    casilla = Escenario.Generar.Escenario.instancia.casillas[x, z];
                                }

                                if (casilla != null)
                                {
                                    if (casilla.construccionPosible == true && casilla.recursoPuesto == false)
                                    {
                                        if (casilla.posicionesSuelo != null)
                                        {
                                            if (casilla.posicionesSuelo.Count > 0)
                                            {                                               
                                                Vector3 posicion = casilla.posicionesSuelo[0];

                                                if (casilla.pisos != null)
                                                {
                                                    if (casilla.pisos.Count > 0)
                                                    {
                                                        posicion.y = 2f * casilla.pisos.Count;
                                                    }
                                                }

                                                vistaPrevia.transform.localPosition = posicion;
                                                vistaPrevia.transform.up = hit.normal;
                                                vistaPrevia.transform.SetParent(casilla.prefab.transform);

                                                Coordenadas coordenadas = vistaPrevia.gameObject.AddComponent<Coordenadas>();
                                                coordenadas.x = x;
                                                coordenadas.z = z;

                                                VistaPreviaUbicar(vistaPrevia);
                                            }
                                        }
                                    }
                                }
                                                            
                            }
                        }
                    }
                }
                else if (recetaConstruccion.tipo == Assets.Tipos.Construccion.Pared)
                {
                    int posicionPared = 0;

                    if (puedeRotar == true)
                    {
                        float rotacionTemp = rotacionLibreEjeY;
                        rotacionLibreEjeY = rotacionLibreEjeY + rotacionVelocidad * Time.deltaTime;

                        if (rotacionLibreEjeY != rotacionTemp)
                        {
                            posicionPared += 1;
                        }

                        if (posicionPared > 3)
                        {
                            posicionPared = 0;
                        }
                    }

                    if (Time.time - ultimaUbicacionTiempo > ubicacionActualizacionVelocidad)
                    {
                        ultimaUbicacionTiempo = Time.time;

                        Ray ray = camara.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                        RaycastHit hit;

                        if (Physics.Raycast(ray, out hit, ubicacionMaximaDistancia, ubicacionLayerMask) == true)
                        {
                            GameObject objeto = hit.collider.gameObject;

                            if (objeto != null)
                            {
                                Assets.Casilla casilla = null;
                                int x = 0;
                                int z = 0;

                                if (objeto.GetComponent<Coordenadas>() != null)
                                {
                                    Coordenadas coordenadas = objeto.GetComponent<Coordenadas>();
                                    x = coordenadas.x;
                                    z = coordenadas.z;
                                    casilla = Escenario.Generar.Escenario.instancia.casillas[x, z];
                                }

                                if (casilla != null)
                                {
                                    if (casilla.pisos != null)
                                    {
                                        if (casilla.pisos.Count > 0)
                                        {
                                            if (casilla.pisos[casilla.pisos.Count - 1].pared == null)
                                            {
                                                Vector3 posicion = casilla.posicionesParedes[posicionPared];

                                                if (casilla.pisos != null)
                                                {
                                                    if (casilla.pisos.Count > 0)
                                                    {
                                                        posicion.y = 2f * (casilla.pisos.Count - 1);
                                                    }
                                                }

                                                vistaPrevia.transform.localPosition = posicion;
                                                vistaPrevia.transform.SetParent(casilla.prefab.transform);

                                                Coordenadas coordenadas = vistaPrevia.gameObject.AddComponent<Coordenadas>();
                                                coordenadas.x = x;
                                                coordenadas.z = z;

                                                VistaPreviaUbicar(vistaPrevia);
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

        private void VistaPreviaUbicar(Construccion.VistaPrevia vistaPrevia)
        {
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

