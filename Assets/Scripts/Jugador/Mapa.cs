using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    public class Mapa : MonoBehaviour
    {
        public GameObject camaraJugador;
        public GameObject camaraMapa;
        private Camera camara;
        public GameObject canvasJugador;
        public GameObject canvasMapa;

        public float zoomCerca = 0.5f;
        public float zoomLejos = 25f;

        public int velocidad = 20;

        private Vector3 ratonOrigenPunto;
        private Vector3 offset;

        private bool arrastrando;

        private int rotacion = 0;

        private Vector2 actualMapaMovimientoInput;
        private float actualMapaZoomInput;
        private float actualMapaArrastreInput;
        public Vector2 actualRatonPosicionInput;

        private bool bloqueo = true;
        private Vector3 temporalJugadorPosicion;
        private Vector3 temporalJugadorRotacion;

        public static Mapa instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Start()
        {
            canvasMapa.SetActive(false);
            camara = camaraMapa.GetComponentInChildren<Camera>();
        }

        public void MapaInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Started)
            {
                AbrirCerrar();
            }
        }

        public void MapaMovimientoInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                actualMapaMovimientoInput = contexto.ReadValue<Vector2>();
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                actualMapaMovimientoInput = Vector2.zero;
            }
        }

        public void MapaZoomInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                actualMapaZoomInput = contexto.ReadValue<float>();
            }
        }

        public void MapaArrastreInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                actualMapaArrastreInput = contexto.ReadValue<float>();
            }
        }

        public void RatonPosicionInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                actualRatonPosicionInput = contexto.ReadValue<Vector2>();
            }
        }

        public void AbrirCerrar()
        {
            if (canvasMapa.activeInHierarchy == true)
            {                
                camaraJugador.SetActive(true);
                camaraMapa.SetActive(false);
                canvasJugador.SetActive(true);
                canvasMapa.SetActive(false);

                Jugador.Movimientos.instancia.Bloquear(false);
                bloqueo = true;

                transform.position = temporalJugadorPosicion;
                transform.eulerAngles = temporalJugadorRotacion;
            }
            else
            {              
                camaraJugador.SetActive(false);
                camaraMapa.SetActive(true);
                canvasJugador.SetActive(false);
                canvasMapa.SetActive(true);

                Jugador.Movimientos.instancia.Bloquear(true);
                bloqueo = false;

                temporalJugadorPosicion = transform.position;
                temporalJugadorRotacion = transform.eulerAngles;
                transform.position = new Vector3(0, 0, 0);
                transform.eulerAngles = new Vector3(0, 0, 0);

                camara.transform.position = new Vector3(temporalJugadorPosicion.x, 60, temporalJugadorPosicion.z);
                camara.transform.eulerAngles = new Vector3(45, 45, 0);
            }
        }

        public void FixedUpdate()
        {
            if (bloqueo == false)
            {
                Movimiento();
                ZoomArrastre();
            }          
        }

        private void Movimiento()
        {
            if (actualMapaMovimientoInput.x > 0 && actualMapaMovimientoInput.y == 0)
            {
                camara.transform.Translate(new Vector3(velocidad * Time.deltaTime * 10, 0, 0));
            }
            else if (actualMapaMovimientoInput.x < 0 && actualMapaMovimientoInput.y == 0)
            {
                camara.transform.Translate(new Vector3(-velocidad * Time.deltaTime * 10, 0, 0));
            }
            else if (actualMapaMovimientoInput.x == 0 && actualMapaMovimientoInput.y > 0)
            {
                camara.transform.Translate(new Vector3(0, velocidad * Time.deltaTime * 10, 0));
            }
            else if (actualMapaMovimientoInput.x == 0 && actualMapaMovimientoInput.y < 0)
            {
                camara.transform.Translate(new Vector3(0, -velocidad * Time.deltaTime * 10, 0));
            }

            camara.transform.position = new Vector3(camara.transform.position.x, 60, camara.transform.position.z);
        }

        private void ZoomArrastre()
        {
            if (actualMapaZoomInput > 0)
            {
                actualMapaZoomInput = 0.1f;
            }
            else if (actualMapaZoomInput < 0)
            {
                actualMapaZoomInput = -0.1f;
            }
            else
            {
                actualMapaZoomInput = 0;
            }

            camara.orthographicSize = Mathf.Clamp(camara.orthographicSize -= actualMapaZoomInput *
                (10f * camara.orthographicSize * .1f), zoomCerca, zoomLejos);

            //------------------------------

           
            if (actualMapaArrastreInput != 0)
            {
                Vector3 ratonPosicion = new Vector3(actualRatonPosicionInput.x, 0, actualRatonPosicionInput.y);
                Debug.Log(actualMapaArrastreInput.ToString());
                offset = camara.ScreenToWorldPoint(ratonPosicion) - camara.transform.position;

                if (arrastrando == false)
                {
                    arrastrando = true;
                    ratonOrigenPunto = camara.ScreenToWorldPoint(ratonPosicion);
                }
            }
            else
            {
                arrastrando = false;
            }
        }
    }
}