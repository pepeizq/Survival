using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Jugador.Inventario
{
    public class Inventario : MonoBehaviour
    {
        public Objetos.Hueco[] huecos;

        public Transform posicionSoltarObjeto;

        private Objetos.Hueco objetoSeleccionado;
        private int objetoSeleccionadoPosicion;

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
            Canvas.Canvas.instancia.inventario.SetActive(false);
            huecos = new Objetos.Hueco[Canvas.Inventario.instancia.huecos.Length];

            int i = 0;
            while (i < huecos.Length)
            {
                huecos[i] = new Objetos.Hueco();
                Canvas.Inventario.instancia.huecos[i].posicion = i;
                Canvas.Inventario.instancia.huecos[i].Quitar();

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
            if (Canvas.Canvas.instancia.inventario.activeInHierarchy == true)
            {
                Canvas.Canvas.instancia.inventario.SetActive(false);
                cerrarInventario.Invoke();
                movimientosJugador.EnseñarCursor(false);
            }
            else
            {
                Canvas.Canvas.instancia.inventario.SetActive(true);
                abrirInventario.Invoke();
                LimpiarObjetoSeleccionado();
                movimientosJugador.EnseñarCursor(true);
            }
        }

        public bool EstaAbierto()
        {
            return Canvas.Canvas.instancia.inventario.activeInHierarchy;
        }

        public void AñadirObjeto(Assets.Objeto objeto)
        {
            if (objeto.puedeCantidad == true)
            {
                Objetos.Hueco huecoRellenar = ObtenerCantidad(objeto);

                if (huecoRellenar != null)
                {
                    huecoRellenar.cantidad += 1;
                    ActualizarInterfaz();
                    return;
                }
            }

            //------------------------

            Objetos.Hueco huecoLibre = ObtenerHuecoVacio();

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

        public void LanzarObjeto(Assets.Objeto objeto)
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
                    Canvas.Inventario.instancia.huecos[i].Añadir(huecos[i]);
                }
                else
                {
                    Canvas.Inventario.instancia.huecos[i].Quitar();
                }

                i += 1;
            }
        }

        public Objetos.Hueco ObtenerCantidad(Assets.Objeto objeto)
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

        public Objetos.Hueco ObtenerHuecoVacio()
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

                Canvas.Inventario.instancia.nombre.text = objetoSeleccionado.objeto.nombre;
                Canvas.Inventario.instancia.descripcion.text = objetoSeleccionado.objeto.descripcion;
                Canvas.Inventario.instancia.atributoNombre.text = string.Empty;
                Canvas.Inventario.instancia.atributoValor.text = string.Empty;

                if (objetoSeleccionado.objeto.consumibles.Length > 0)
                {
                    int i = 0;
                    while (i < objetoSeleccionado.objeto.consumibles.Length)
                    {
                        Canvas.Inventario.instancia.atributoNombre.text = Canvas.Inventario.instancia.atributoNombre.text + objetoSeleccionado.objeto.consumibles[i].tipo.ToString() + "\n";
                        Canvas.Inventario.instancia.atributoValor.text = Canvas.Inventario.instancia.atributoValor.text + objetoSeleccionado.objeto.consumibles[i].valor.ToString() + "\n";

                        i += 1;
                    }
                }

                if (objetoSeleccionado.objeto.tipo == Assets.Tipos.Objeto.Consumible)
                {
                    Canvas.Inventario.instancia.botonUsar.SetActive(true);
                    Canvas.Inventario.instancia.botonEquipar.SetActive(false);
                    Canvas.Inventario.instancia.botonDesequipar.SetActive(false);
                }

                if (objetoSeleccionado.objeto.tipo == Assets.Tipos.Objeto.Equipable && Canvas.Inventario.instancia.huecos[posicion].equipado == false)
                {
                    Canvas.Inventario.instancia.botonUsar.SetActive(false);
                    Canvas.Inventario.instancia.botonEquipar.SetActive(true);
                    Canvas.Inventario.instancia.botonDesequipar.SetActive(false);
                }

                if (objetoSeleccionado.objeto.tipo == Assets.Tipos.Objeto.Equipable && Canvas.Inventario.instancia.huecos[posicion].equipado == true)
                {
                    Canvas.Inventario.instancia.botonUsar.SetActive(false);
                    Canvas.Inventario.instancia.botonEquipar.SetActive(false);
                    Canvas.Inventario.instancia.botonDesequipar.SetActive(true);
                }

                Canvas.Inventario.instancia.botonSoltar.SetActive(true);
            }

        }

        public void LimpiarObjetoSeleccionado()
        {
            objetoSeleccionado = null;

            Canvas.Inventario.instancia.nombre.text = string.Empty;
            Canvas.Inventario.instancia.descripcion.text = string.Empty;
            Canvas.Inventario.instancia.atributoNombre.text = string.Empty;
            Canvas.Inventario.instancia.atributoValor.text = string.Empty;

            Canvas.Inventario.instancia.botonUsar.SetActive(false);
            Canvas.Inventario.instancia.botonEquipar.SetActive(false);
            Canvas.Inventario.instancia.botonDesequipar.SetActive(false);
            Canvas.Inventario.instancia.botonSoltar.SetActive(false);
        }

        public void UsarBoton()
        {
            if (objetoSeleccionado.objeto.tipo == Assets.Tipos.Objeto.Consumible)
            {
                if (objetoSeleccionado.objeto.consumibles.Length > 0)
                {
                    int i = 0;
                    while (i < objetoSeleccionado.objeto.consumibles.Length)
                    {
                        switch (objetoSeleccionado.objeto.consumibles[i].tipo)
                        {
                            case Assets.Tipos.Consumible.Salud: 
                                necesidadesJugador.Curar(objetoSeleccionado.objeto.consumibles[i].valor); 
                                break;

                            case Assets.Tipos.Consumible.Hambre:
                                necesidadesJugador.Comer(objetoSeleccionado.objeto.consumibles[i].valor);
                                break;

                            case Assets.Tipos.Consumible.Sed:
                                necesidadesJugador.Beber(objetoSeleccionado.objeto.consumibles[i].valor);
                                break;

                            case Assets.Tipos.Consumible.Sueño:
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
            if (Canvas.Inventario.instancia.huecos[objetoEquipadoPosicion].equipado == true)
            {
                Desequipar(objetoEquipadoPosicion);
            }

            Canvas.Inventario.instancia.huecos[objetoSeleccionadoPosicion].equipado = true;
            objetoEquipadoPosicion = objetoSeleccionadoPosicion;
            Equipar.instancia.EquiparNuevo(objetoSeleccionado.objeto);
            ActualizarInterfaz();

            SeleccionarObjeto(objetoSeleccionadoPosicion);

            if (Canvas.Inventario.instancia.huecos[objetoEquipadoPosicion].equipado == true)
            {
                AbrirCerrar();
            }
        }

        public void Desequipar(int posicion)
        {
            Canvas.Inventario.instancia.huecos[posicion].equipado = false;
            Equipar.instancia.Desequipar();
            ActualizarInterfaz();

            if (objetoSeleccionadoPosicion == posicion)
            {
                SeleccionarObjeto(posicion);
            }
        }

        public void DesequiparBoton()
        {
            Desequipar(objetoSeleccionadoPosicion);
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
                if (Canvas.Inventario.instancia.huecos[objetoSeleccionadoPosicion].equipado == true)
                {
                    Desequipar(objetoSeleccionadoPosicion);
                }

                objetoSeleccionado.objeto = null;
                LimpiarObjetoSeleccionado();
            }

            ActualizarInterfaz();
        }

        public void QuitarObjeto(Assets.Objeto objeto)
        {
            int i = 0;
            while (i < huecos.Length)
            {
                if (huecos[i].objeto == objeto)
                {
                    huecos[i].cantidad = huecos[i].cantidad - 1;

                    if (huecos[i].cantidad == 0)
                    {
                        if (Canvas.Inventario.instancia.huecos[i].equipado == true)
                        {
                            Desequipar(i);
                        }

                        huecos[i].objeto = null;
                        LimpiarObjetoSeleccionado();
                    }

                    ActualizarInterfaz();
                    return;
                }

                i += 1;
            }
        }

        public bool TieneObjetos(Assets.Objeto objeto, int cantidad)
        {
            int cantidadTemp = 0;

            int i = 0;
            while (i < huecos.Length)
            {
                if (huecos[i].objeto == objeto)
                {
                    cantidadTemp = cantidadTemp + huecos[i].cantidad;
                }

                if (cantidadTemp >= cantidad)
                {
                    return true;
                }

                i += 1;
            }

            return false;
        }
    }
}