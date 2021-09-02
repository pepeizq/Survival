using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    public class Mapa : MonoBehaviour
    {
        public GameObject camaraJugador;
        public GameObject camaraMapa;
        public GameObject cuerpoJugador;
        private Camera camara;

        public float zoomCerca = 0.5f;
        public float zoomLejos = 25f;

        public int velocidad = 20;

        private bool arrastrando;

        private Vector2 actualMapaMovimientoInput;
        private float actualMapaZoomInput;

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
            Canvas.Canvas.instancia.mapa.SetActive(false);
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

        public void AbrirCerrar()
        {
            if (Canvas.Canvas.instancia.mapa.activeInHierarchy == true)
            {                
                camaraJugador.SetActive(true);
                camaraMapa.SetActive(false);
                cuerpoJugador.SetActive(false);
                Canvas.Canvas.instancia.juego.SetActive(true);
                Canvas.Canvas.instancia.mapa.SetActive(false);

                Movimientos.instancia.Bloquear(false);
                bloqueo = true;

                transform.position = temporalJugadorPosicion;
                transform.eulerAngles = temporalJugadorRotacion;
            }
            else
            {              
                camaraJugador.SetActive(false);
                camaraMapa.SetActive(true);
                cuerpoJugador.SetActive(true);
                
                Canvas.Canvas.instancia.juego.SetActive(false);
                Canvas.Canvas.instancia.mapa.SetActive(true);

                Movimientos.instancia.Bloquear(true);
                bloqueo = false;

                temporalJugadorPosicion = transform.position;
                temporalJugadorRotacion = transform.eulerAngles;
                transform.position = new Vector3(0, 0, 0);
                transform.eulerAngles = new Vector3(0, 0, 0);

                cuerpoJugador.gameObject.transform.position = new Vector3(temporalJugadorPosicion.x, temporalJugadorPosicion.y + 1f, temporalJugadorPosicion.z);
                camara.transform.position = new Vector3(temporalJugadorPosicion.x - 30f, 60, temporalJugadorPosicion.z - 30f);
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

            if (arrastrando == false)
            {
                camara.transform.position = new Vector3(camara.transform.position.x, 60, camara.transform.position.z);
            }                
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
        }
    }
}