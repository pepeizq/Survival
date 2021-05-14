using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

namespace Jugador
{
    public class Inventario : MonoBehaviour
    {
        public Interfaz.Inventario.Hueco[] huecosInterfaz;
        public Jugador.Objetos.Inventario.Hueco[] huecos;

        public GameObject canvasInventario;
        public Transform posicionSoltarObjeto;

        [Header("Objeto Seleccionado")]
        private Jugador.Objetos.Inventario.Hueco objetoSeleccionado;
        private int objetoSeleccionadoPosicion;

        public TextMeshProUGUI nombre;
        public TextMeshProUGUI descripcion;
        public TextMeshProUGUI atributoNombre;
        public TextMeshProUGUI atributoValor;

        public GameObject botonUsar;
        public GameObject botonEquipar;
        public GameObject botonDesequipar;
        public GameObject botonSoltar;

        private int objetoEquipadoPosicion;

        private Movimientos controlador;

        [Header("Eventos")]
        public UnityEvent abrirInventario;
        public UnityEvent cerrarInventario;

        public static Inventario instancia;

        public void Awake()
        {
            instancia = this;
            controlador = GetComponent<Movimientos>();
        }

        public void Start()
        {
            canvasInventario.SetActive(false);
            huecos = new Jugador.Objetos.Inventario.Hueco[huecosInterfaz.Length];

            int i = 0;
            while (i < huecos.Length)
            {
                huecos[i] = new Jugador.Objetos.Inventario.Hueco();
                huecosInterfaz[i].posicion = i;
                huecosInterfaz[i].Quitar();

                i += 1;
            }
        }

        public void AbrirCerrar()
        {

        }

        public bool EstaAbierto()
        {
            return canvasInventario.activeInHierarchy;
        }

        public void AñadirObjeto(Objeto.Datos objeto)
        {
            if (objeto.puedeCantidad == true)
            {
                Jugador.Objetos.Inventario.Hueco huecoRellenar = ObtenerCantidad(objeto);

                if (huecoRellenar != null)
                {
                    huecoRellenar.cantidad += 1;
                    ActualizarInterfaz();
                    return;
                }
            }

            Jugador.Objetos.Inventario.Hueco huecoLibre = ObtenerHuecoVacio();

            if (huecoLibre != null)
            {
                huecoLibre.objeto = objeto;
                huecoLibre.cantidad = 1;
                ActualizarInterfaz();
                return;
            }

            LanzarObjeto(objeto);
        }

        public void LanzarObjeto(Objeto.Datos objeto)
        {

        }

        public void ActualizarInterfaz()
        {

        }

        public Jugador.Objetos.Inventario.Hueco ObtenerCantidad(Objeto.Datos objeto)
        {
            return null;
        }

        public Jugador.Objetos.Inventario.Hueco ObtenerHuecoVacio()
        {
            return null;
        }

        public void SeleccionarObjeto(int posicion)
        {

        }

        public void LimpiarObjetoSeleccionado()
        {

        }

        public void UsarBoton()
        {

        }

        public void EquiparBoton()
        {

        }

        public void Desequipar()
        {

        }

        public void DesequiparBoton()
        {

        }

        public void SoltarBoton()
        {

        }

        public void QuitarObjetoSeleccionado()
        {

        }

        public void QuitarObjeto(Objeto.Datos objeto)
        {

        }

        public bool TieneObjetos(Objeto.Datos objeto, int cantidad)
        {
            return false;
        }
    }
}


namespace Jugador.Objetos.Inventario
{
    public class Hueco
    {
        public Objeto.Datos objeto;
        public int cantidad;
    }
}

