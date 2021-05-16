using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Interfaz.Inventario
{
    public class Hueco : MonoBehaviour
    {
        public Button boton;
        public Image icono;
        public TextMeshProUGUI cantidad;
        private Jugador.Objetos.Inventario.Hueco actualHueco;
        private Outline outline;
        public int posicion;
        public bool equipado;

        public void Awake()
        {
            outline = GetComponent<Outline>();
        }

        public void OnEnable()
        {
            outline.enabled = equipado;
        }

        public void OnDisable()
        {

        }

        public void Añadir(Jugador.Objetos.Inventario.Hueco hueco)
        {
            actualHueco = hueco;

            icono.gameObject.SetActive(true);
            icono.sprite = hueco.objeto.icono;
            cantidad.text = hueco.cantidad > 1 ? hueco.cantidad.ToString() : string.Empty;

            if (outline != null)
            {
                outline.enabled = equipado;
            }
        }

        public void Quitar()
        {
            actualHueco = null;

            icono.gameObject.SetActive(false);
            cantidad.text = string.Empty;
        }

        public void ClickearBoton()
        {
            Jugador.Inventario.instancia.SeleccionarObjeto(posicion);
        }
    }
}