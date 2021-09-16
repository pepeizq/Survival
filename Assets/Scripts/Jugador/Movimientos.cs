using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    public class Movimientos : MonoBehaviour
    {
        [Header("Salto")]
        public float saltoFuerza;
        public LayerMask terrenoLayer;

        [Header("Movimiento")]
        public float movimientoVelocidad;
        private Vector2 actualMovimientoInput;

        [Header("Mirar")]
        public Transform camaraContenedor;
        public float minXMirar;
        public float maxXMirar;
        private float camaraCurvaXRotacion;
        public float sensibilidadMirar;
        [HideInInspector] public bool puedeMirar = true;
        [HideInInspector] private bool bloqueo = false;

        private Vector2 ratonDelta;

        private Rigidbody cuerpo;

        public static Movimientos instancia;

        public void Awake()
        {
            instancia = this;
            cuerpo = GetComponent<Rigidbody>();
        }

        public void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        public void FixedUpdate()
        {
            if (bloqueo == false)
            {
                Movimiento();
            }            
        }

        public void LateUpdate()
        {
            if (bloqueo == false)
            {
                if (puedeMirar == true)
                {
                    MirarCamara();
                }
            }                
        }

        public void Movimiento()
        {
            Vector3 direccion = transform.forward * actualMovimientoInput.y + transform.right * actualMovimientoInput.x;
            direccion *= movimientoVelocidad;
            direccion.y = cuerpo.velocity.y;

            cuerpo.velocity = direccion;
        }

        public void MirarCamara()
        {
            //Mirar arriba y abajo
            camaraCurvaXRotacion += ratonDelta.y * sensibilidadMirar;
            camaraCurvaXRotacion = Mathf.Clamp(camaraCurvaXRotacion, minXMirar, maxXMirar);
            camaraContenedor.localEulerAngles = new Vector3(-camaraCurvaXRotacion, 0, 0);

            //Mirar izquierda y derecha
            transform.localEulerAngles += new Vector3(0, ratonDelta.x * sensibilidadMirar, 0);
        }

        public void MirarInput(InputAction.CallbackContext contexto)
        {
            ratonDelta = contexto.ReadValue<Vector2>();
        }

        public void MovimientoInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                actualMovimientoInput = contexto.ReadValue<Vector2>();
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                actualMovimientoInput = Vector2.zero;
            }
        }

        public void SaltoInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Started)
            {
                if (DetectorTerreno() == true)
                {
                    cuerpo.AddForce(Vector3.up * saltoFuerza, ForceMode.Impulse);
                }
            }
        }

        private bool DetectorTerreno()
        {
            Ray[] detectores = new Ray[4]
            {
            new Ray(transform.position + (transform.forward * 0.2f) + (Vector3.up * 0.01f), Vector3.down),
            new Ray(transform.position + (-transform.forward * 0.2f) + (Vector3.up * 0.01f), Vector3.down),
            new Ray(transform.position + (transform.right * 0.2f) + (Vector3.up * 0.01f), Vector3.down),
            new Ray(transform.position + (-transform.right * 0.2f) + (Vector3.up * 0.01f), Vector3.down)
            };

            int i = 0;
            while (i < detectores.Length)
            {
                if (Physics.Raycast(detectores[i], 0.1f, terrenoLayer) == true)
                {
                    return true;
                }

                i += 1;
            }

            return false;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.magenta;

            Gizmos.DrawRay(transform.position + (transform.forward * 0.2f), Vector3.down);
            Gizmos.DrawRay(transform.position + (-transform.forward * 0.2f), Vector3.down);
            Gizmos.DrawRay(transform.position + (transform.right * 0.2f), Vector3.down);
            Gizmos.DrawRay(transform.position + (-transform.right * 0.2f), Vector3.down);
        }

        public void EnseñarCursor(bool enseñar)
        {
            if (enseñar == true)
            {
                Cursor.lockState = CursorLockMode.None;
                puedeMirar = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                puedeMirar = true;
            }
        }

        public void Bloquear(bool estado)
        {
            bloqueo = estado;
            cuerpo.isKinematic = estado;
        }
    }
}

