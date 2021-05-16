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

        private Movimientos movimientosJugador;
        private Necesidades necesidadesJugador;

        [Header("Eventos")]
        public UnityEvent abrirInventario;
        public UnityEvent cerrarInventario;

        public static Inventario instancia;

        public void Awake()
        {
            instancia = this;
            movimientosJugador = GetComponent<Movimientos>();
            necesidadesJugador = GetComponent<Necesidades>();
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

            LimpiarObjetoSeleccionado();
        }

        public void InventarioInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Started)
            {
                AbrirCerrar();
            }
        }

        public void AbrirCerrar()
        {
            if (canvasInventario.activeInHierarchy == true)
            {
                canvasInventario.SetActive(false);
                cerrarInventario.Invoke();
                movimientosJugador.EnseñarCursor(false);
            }
            else
            {
                canvasInventario.SetActive(true);
                abrirInventario.Invoke();
                LimpiarObjetoSeleccionado();
                movimientosJugador.EnseñarCursor(true);
            }
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

            //------------------------

            Jugador.Objetos.Inventario.Hueco huecoLibre = ObtenerHuecoVacio();

            if (huecoLibre != null)
            {
                huecoLibre.objeto = objeto;
                huecoLibre.cantidad = 1;
                ActualizarInterfaz();
                return;
            }

            //------------------------

            LanzarObjeto(objeto);
        }

        public void LanzarObjeto(Objeto.Datos objeto)
        {
            Instantiate(objeto.prefab, posicionSoltarObjeto.position, Quaternion.Euler(Vector3.one * Random.value * 360.0f));
        }

        public void ActualizarInterfaz()
        {
            int i = 0;
            while (i < huecos.Length)
            {
                if (huecos[i].objeto != null)
                {
                    huecosInterfaz[i].Añadir(huecos[i]);
                }
                else
                {
                    huecosInterfaz[i].Quitar();
                }

                i += 1;
            }
        }

        public Jugador.Objetos.Inventario.Hueco ObtenerCantidad(Objeto.Datos objeto)
        {
            int i = 0;
            while (i < huecos.Length)
            {
                if (huecos[i].objeto == objeto && huecos[i].cantidad < objeto.cantidadMaxima)
                {
                    return huecos[i];
                }

                i += 1;
            }

            return null;
        }

        public Jugador.Objetos.Inventario.Hueco ObtenerHuecoVacio()
        {
            int i = 0;
            while (i < huecos.Length)
            {
                if (huecos[i].objeto == null)
                {
                    return huecos[i];
                }

                i += 1;
            }

            return null;
        }

        public void SeleccionarObjeto(int posicion)
        {
            if (huecos[posicion].objeto == null)
            {
                return;
            }
            else
            {
                objetoSeleccionado = huecos[posicion];
                objetoSeleccionadoPosicion = posicion;

                nombre.text = objetoSeleccionado.objeto.nombre;
                descripcion.text = objetoSeleccionado.objeto.descripcion;
                atributoNombre.text = string.Empty;
                atributoValor.text = string.Empty;

                if (objetoSeleccionado.objeto.consumibles.Length > 0)
                {
                    int i = 0;
                    while (i < objetoSeleccionado.objeto.consumibles.Length)
                    {
                        atributoNombre.text = atributoNombre.text + objetoSeleccionado.objeto.consumibles[i].tipo.ToString() + "\n";
                        atributoValor.text = atributoValor.text + objetoSeleccionado.objeto.consumibles[i].valor.ToString() + "\n";

                        i += 1;
                    }
                }

                if (objetoSeleccionado.objeto.tipo == ObjetoTipo.Consumible)
                {
                    botonUsar.SetActive(true);
                }

                if (objetoSeleccionado.objeto.tipo == ObjetoTipo.Equipable && huecosInterfaz[posicion].equipado == false)
                {
                    botonEquipar.SetActive(true);
                }

                if (objetoSeleccionado.objeto.tipo == ObjetoTipo.Equipable && huecosInterfaz[posicion].equipado == true)
                {
                    botonDesequipar.SetActive(true);
                }

                botonSoltar.SetActive(true);
            }

        }

        public void LimpiarObjetoSeleccionado()
        {
            objetoSeleccionado = null;

            nombre.text = string.Empty;
            descripcion.text = string.Empty;
            atributoNombre.text = string.Empty;
            atributoValor.text = string.Empty;

            botonUsar.SetActive(false);
            botonEquipar.SetActive(false);
            botonDesequipar.SetActive(false);
            botonSoltar.SetActive(false);
        }

        public void UsarBoton()
        {
            if (objetoSeleccionado.objeto.tipo == ObjetoTipo.Consumible)
            {
                if (objetoSeleccionado.objeto.consumibles.Length > 0)
                {
                    int i = 0;
                    while (i < objetoSeleccionado.objeto.consumibles.Length)
                    {
                        switch (objetoSeleccionado.objeto.consumibles[i].tipo)
                        {
                            case ConsumibleTipo.Salud: 
                                necesidadesJugador.Curar(objetoSeleccionado.objeto.consumibles[i].valor); 
                                break;

                            case ConsumibleTipo.Hambre:
                                necesidadesJugador.Comer(objetoSeleccionado.objeto.consumibles[i].valor);
                                break;

                            case ConsumibleTipo.Sed:
                                necesidadesJugador.Beber(objetoSeleccionado.objeto.consumibles[i].valor);
                                break;

                            case ConsumibleTipo.Sueño:
                                necesidadesJugador.Dormir(objetoSeleccionado.objeto.consumibles[i].valor);
                                break;
                        }

                        i += 1;
                    }
                }

            }

            QuitarObjetoSeleccionado();
        }

        public void EquiparBoton()
        {

        }

        public void Desequipar(int posicion)
        {

        }

        public void DesequiparBoton()
        {

        }

        public void SoltarBoton()
        {
            LanzarObjeto(objetoSeleccionado.objeto);
            QuitarObjetoSeleccionado();
        }

        public void QuitarObjetoSeleccionado()
        {
            objetoSeleccionado.cantidad -= 1;

            if (objetoSeleccionado.cantidad == 0)
            {
                if (huecosInterfaz[objetoSeleccionadoPosicion].equipado == true)
                {
                    Desequipar(objetoSeleccionadoPosicion);
                }

                objetoSeleccionado.objeto = null;
                LimpiarObjetoSeleccionado();
            }

            ActualizarInterfaz();
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

