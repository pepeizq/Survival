using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Interaccion : MonoBehaviour
{
    public float comprobacion = 0.05f;
    private float ultimaComprobacion;
    public float distanciaMaxima;
    public LayerMask interactuableLayer;

    private GameObject curvaInteraccionGameObject;
    private IInteractuable curvaInteraccion;

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
                if (hit.collider.gameObject != curvaInteraccionGameObject)
                {
                    curvaInteraccionGameObject = hit.collider.gameObject;
                    curvaInteraccion = hit.collider.GetComponent<IInteractuable>();
                    MostrarMensajeTexto();
                }
            }
            else
            {
                curvaInteraccionGameObject = null;
                curvaInteraccion = null;
                mensajeTexto.gameObject.SetActive(false);
            }
        }
    }

    public void MostrarMensajeTexto()
    {
        mensajeTexto.gameObject.SetActive(true);
        mensajeTexto.text = string.Format("<b>[E]</b> {0}", curvaInteraccion.MensajeDisponible());
    }

    public void InteractuarInput(InputAction.CallbackContext contexto)
    {
        if (contexto.phase == InputActionPhase.Started && curvaInteraccion != null)
        {
            curvaInteraccion.Interactuar();
            curvaInteraccionGameObject = null;
            curvaInteraccion = null;
            mensajeTexto.gameObject.SetActive(false);
        }
    }
}

public interface IInteractuable
{
    string MensajeDisponible();
    void Interactuar();
}
