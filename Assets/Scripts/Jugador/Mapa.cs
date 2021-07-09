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
        private bool rotando;

        private int rotacion = 0;

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

                camara.transform.position = new Vector3(temporalJugadorPosicion.x + 10, 60, temporalJugadorPosicion.z + 10);
                camara.transform.eulerAngles = new Vector3(45, 45, 0);
            }
        }

        public void FixedUpdate()
        {
            if (bloqueo == false)
            {
                Movimiento();
                Zoom();
            }          
        }

        //public void FixedUpdate()
        //{
        //    //if (juego.canvas.gameObject.GetComponent<CanvasGroup>().alpha == 1 || juego.ocultarEnse�arInterfaz == true)
        //    //{
        //    //int velocidad = 20;

        //    if (rotando == false)
        //    {
        //        if (arrastrando == false)
        //        {
        //            //if (Input.GetKey(teclaMovimientoDerecha))
        //            //{
        //            //    Movimiento(velocidad * Time.deltaTime, 0);
        //            //}
        //            //else if (Input.GetKey(teclaMovimientoIzquierda))
        //            //{
        //            //    Movimiento(-velocidad * Time.deltaTime, 0);
        //            //}
        //            //else if (Input.GetKey(teclaMovimientoAbajo))
        //            //{
        //            //    Movimiento(0, -velocidad * Time.deltaTime);
        //            //}
        //            //else if (Input.GetKey(teclaMovimientoArriba))
        //            //{
        //            //    Movimiento(0, velocidad * Time.deltaTime);
        //            //}

        //            //if (Input.GetKeyDown(teclaRotacionIzquierda))
        //            //{
        //            //    RotacionIzquierda(false);
        //            //}
        //            //else if (Input.GetKeyDown(teclaRotacionDerecha))
        //            //{
        //            //    RotacionDerecha(false);
        //            //}
        //        }
        //    }
        //    //}
        //}

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


            //if (rotacion == 0)
            //{
            //    if ((posicionFinal.position.x > -40) && (posicionFinal.position.z > -40) && (posicionFinal.position.x < 60) && (posicionFinal.position.z < 60))
            //    {
            //        transform.Translate(new Vector3(x, y, 0));
            //    }
            //    else
            //    {
            //        transform.Translate(new Vector3(-x * 20, -y * 20, 0));
            //    }
            //}
            //else if ((rotacion == 90) || (rotacion == -270))
            //{
            //    if ((posicionFinal.position.x > -40) && (posicionFinal.position.z > 40) && (posicionFinal.position.x < 60) && (posicionFinal.position.z < 135))
            //    {
            //        transform.Translate(new Vector3(x, y, 0));
            //    }
            //    else
            //    {
            //        transform.Translate(new Vector3(-x * 20, -y * 20, 0));
            //    }
            //}
            //else if ((rotacion == 180) || (rotacion == -180))
            //{
            //    if ((posicionFinal.position.x > 40) && (posicionFinal.position.z > 40) && (posicionFinal.position.x < 135) && (posicionFinal.position.z < 135))
            //    {
            //        transform.Translate(new Vector3(x, y, 0));
            //    }
            //    else
            //    {
            //        transform.Translate(new Vector3(-x * 20, -y * 20, 0));
            //    }
            //}
            //else if ((rotacion == 270) || (rotacion == -90))
            //{
            //    if ((posicionFinal.position.x > 40) && (posicionFinal.position.z > -40) && (posicionFinal.position.x < 140) && (posicionFinal.position.z < 60))
            //    {
            //        transform.Translate(new Vector3(x, y, 0));
            //    }
            //    else
            //    {
            //        transform.Translate(new Vector3(-x * 20, -y * 20, 0));
            //    }
            //}
        }

        private void Zoom()
        {
            if (actualMapaZoomInput >= 0)
            {
                actualMapaZoomInput = 0.1f;
            }
            else if (actualMapaZoomInput < 0)
            {
                actualMapaZoomInput = -0.1f;
            }

            camara.orthographicSize = Mathf.Clamp(camara.orthographicSize -= actualMapaZoomInput *
                (10f * camara.orthographicSize * .1f), zoomCerca, zoomLejos);

            //if (Input.GetMouseButton(2))
            //{
            //    offset = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);

            //    if (arrastrando == false)
            //    {
            //        arrastrando = true;
            //        ratonOrigenPunto = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //    }
            //}
            //else
            //{
            //    arrastrando = false;
            //}
        }

        public void RotacionIzquierda(bool sonidob)
        {
            if (sonidob == true)
            {
                //sonido.RatonClick();
            }

            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //RaycastHit hit;

            //if (Physics.Raycast(ray, out hit))
            //{
            //    Vector3 posicion = hit.point;

            //    StartCoroutine(Rotar(posicion, -2));
            //    rotacion -= 90;

            //    if (rotacion < -270)
            //    {
            //        rotacion = 0;
            //    }
            //}

            Vector3 posicion = ray.origin;

            StartCoroutine(Rotar(posicion, -2));
            rotacion -= 90;

            if (rotacion < -270)
            {
                rotacion = 0;
            }
        }

        public void RotacionDerecha(bool sonidob)
        {
            if (sonidob == true)
            {
                //sonido.RatonClick();
            }

            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 posicion = hit.point;

                StartCoroutine(Rotar(posicion, 2));
                rotacion += 90;

                if (rotacion > 270)
                {
                    rotacion = 0;
                }
            }
        }

        private IEnumerator Rotar(Vector3 posicion, int cantidad)
        {
            rotando = true;
            for (float t = 0; t < 45; t += 1)
            {
                transform.RotateAround(posicion, Vector3.up, cantidad);
                yield return null;
            }
            rotando = false;
        }

        private void LateUpdate()
        {
            //if (juego.canvas.gameObject.GetComponent<CanvasGroup>().alpha == 1 || juego.ocultarEnse�arInterfaz == true)
            //{
            if (rotando == false)
            {
                //Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") *
                //    (10f * Camera.main.orthographicSize * .1f), zoomCerca, zoomLejos);

                //if (Input.GetMouseButton(2))
                //{
                //    offset = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);

                //    if (arrastrando == false)
                //    {
                //        arrastrando = true;
                //        ratonOrigenPunto = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //    }
                //}
                //else
                //{
                //    arrastrando = false;
                //}
            }

            if (arrastrando == true)
            {
                Vector3 posicionFinal = ratonOrigenPunto - offset;

                if (rotacion == 0)
                {
                    if ((posicionFinal.x > -40) && (posicionFinal.z > -40) && (posicionFinal.x < 60) && (posicionFinal.z < 60))
                    {
                        transform.position = new Vector3(posicionFinal.x, 60, posicionFinal.z);
                    }
                }
                else if ((rotacion == 90) || (rotacion == -270))
                {
                    if ((posicionFinal.x > -40) && (posicionFinal.z > 40) && (posicionFinal.x < 60) && (posicionFinal.z < 135))
                    {
                        transform.position = new Vector3(posicionFinal.x, 60, posicionFinal.z);
                    }
                }
                else if ((rotacion == 180) || (rotacion == -180))
                {
                    if ((posicionFinal.x > 40) && (posicionFinal.z > 40) && (posicionFinal.x < 135) && (posicionFinal.z < 135))
                    {
                        transform.position = new Vector3(posicionFinal.x, 60, posicionFinal.z);
                    }
                }
                else if ((rotacion == 270) || (rotacion == -90))
                {
                    if ((posicionFinal.x > 40) && (posicionFinal.z > -40) && (posicionFinal.x < 140) && (posicionFinal.z < 60))
                    {
                        transform.position = new Vector3(posicionFinal.x, 60, posicionFinal.z);
                    }
                }
            }
            //}       
        }
    }
}