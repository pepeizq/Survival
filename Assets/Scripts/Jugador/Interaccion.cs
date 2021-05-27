using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

namespace Jugador
{
    public class Interaccion : MonoBehaviour
    {
        public float comprobacion = 0.05f;
        private float ultimaComprobacion;
        public float distanciaMaxima;
        public LayerMask interactuableLayer;

        private GameObject actualInteraccionGameObject;
        private IInteractuable actualInteraccion;

        public TextMeshProUGUI mensajeTexto;
        private Camera camara;

        public void Start()
        {
            camara = Camera.main;
        }

        public void Update()
        {
            if (Time.time - ultimaComprobacion > comprobacion)
            {
                ultimaComprobacion = Time.time;

                Ray ray = camara.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, distanciaMaxima, interactuableLayer) == true)
                {
                    if (hit.collider.gameObject != actualInteraccionGameObject)
                    {
                        actualInteraccionGameObject = hit.collider.gameObject;
                        actualInteraccion = hit.collider.GetComponent<IInteractuable>();
                        MostrarMensajeTexto();
                    }
                }
                else
                {
                    actualInteraccionGameObject = null;
                    actualInteraccion = null;
                    mensajeTexto.gameObject.SetActive(false);
                }
            }
        }

        public void MostrarMensajeTexto()
        {
            mensajeTexto.gameObject.SetActive(true);
            mensajeTexto.text = string.Format("<b>[E]</b> {0}", actualInteraccion.MensajeMostrar());
        }

        public void InteractuarInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Started && actualInteraccion != null)
            {
                actualInteraccion.Interactuar();
                actualInteraccionGameObject = null;
                actualInteraccion = null;
                mensajeTexto.gameObject.SetActive(false);
            }
        }
    }
}

public interface IInteractuable
{
    string MensajeMostrar();
    void Interactuar();
}
