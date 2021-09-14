using UnityEngine;
using UnityEngine.InputSystem;

namespace Partida
{
    public class Guardar : MonoBehaviour
    {
        public static Guardar instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Update()
        {

        }

        public void GuardarInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Started)
            {
                RecopilarDatos();
            }
        }

        public void RecopilarDatos()
        {
            Datos partida = new Datos
            {
                jugadorPosicion = new VectorTres(Jugador.Movimientos.instancia.transform.position),
                jugadorRotacion = new VectorTres(Jugador.Movimientos.instancia.transform.eulerAngles),
                jugadorMirar = new VectorTres(Jugador.Movimientos.instancia.camaraContenedor.localEulerAngles),

                vida = Jugador.Necesidades.instancia.vida.valorActual,
                hambre = Jugador.Necesidades.instancia.hambre.valorActual,
                sed = Jugador.Necesidades.instancia.sed.valorActual,
                sue�o = Jugador.Necesidades.instancia.sue�o.valorActual,

                tiempoDia = Escenario.DiaNoche.instancia.tiempo
            };

            //------------------------------------------------

            partida = Casillas(partida);
            partida = Inventario(partida);
            partida = Objetos(partida);

            //------------------------------------------------

            //Construccion.Propiedades[] construcciones = FindObjectsOfType<Construccion.Propiedades>();
            //partida.construcciones = new PartidaConstruccion[construcciones.Length];

            //i = 0;
            //while (i < construcciones.Length)
            //{
            //    partida.construcciones[i] = new PartidaConstruccion
            //    {
            //        id = construcciones[i].asset.id,
            //        posicion = new VectorTres(construcciones[i].asset.prefab.transform.position),
            //        rotacion = new VectorTres(construcciones[i].asset.prefab.transform.localEulerAngles),
            //        propiedades = construcciones[i].CogerPropiedades()
            //    };

            //    i += 1;
            //}

            //------------------------------------------------

            //partida.recursos = new PartidaRecurso[Gestor.instancia.recursos.Length];

            //i = 0;
            //while (i < Gestor.instancia.recursos.Length)
            //{
            //    partida.recursos[i] = new PartidaRecurso();
            //    partida.recursos[i].index = i;

            //    if (Gestor.instancia.recursos[i] == null)
            //    {
            //        partida.recursos[i].destruido = true;
            //    }
            //    else
            //    {
            //        partida.recursos[i].destruido = false;
            //        partida.recursos[i].capacidad = Gestor.instancia.recursos[i].cantidad;
            //    }           

            //    i += 1;
            //}

            //------------------------------------------------

            //Enemigos.Enemigo[] enemigos = FindObjectsOfType<Enemigos.Enemigo>();
            //partida.enemigos = new PartidaEnemigo[enemigos.Length];

            //i = 0;
            //while (i < enemigos.Length)
            //{
            //    partida.enemigos[i] = new PartidaEnemigo
            //    {
            //        prefabId = enemigos[i].asset.id,
            //        posicion = new VectorTres(enemigos[i].asset.prefab.transform.position),
            //        rotacion = new VectorTres(enemigos[i].asset.prefab.transform.localEulerAngles),
            //        iaEstado = (int)enemigos[i].iaEstado,
            //        intentaMoverse = !enemigos[i].agente.isStopped,
            //        posicionDestino = new VectorTres(enemigos[i].agente.destination)
            //    };

            //    i += 1;
            //}

            //------------------------------------------------

            string datos = JsonUtility.ToJson(partida);
            PlayerPrefs.SetString("Guardar", datos);

            Debug.Log("Partida Guardada");
        }

        private Datos Casillas(Datos partida)
        {
            partida.casillas = new PartidaCasilla[Gestor.instancia.casillas.Length];

            int i = 0;
            while (i < Gestor.instancia.casillas.Length)
            {
                partida.casillas[i] = new PartidaCasilla();
                partida.casillas[i].idCasilla = Gestor.instancia.casillas[i].id;

                if (Gestor.instancia.casillas[i].isla != null)
                {
                    partida.casillas[i].idIsla = Gestor.instancia.casillas[i].isla.id;
                }
                else
                {
                    partida.casillas[i].idIsla = 9999;
                }
                
                partida.casillas[i].coordenadas = new VectorTres(Gestor.instancia.casillas[i].posicion);
                partida.casillas[i].rotacion = Gestor.instancia.casillas[i].rotacion;

                i += 1;
            }

            return partida;
        }

        private Datos Inventario(Datos partida)
        {
            partida.inventario = new PartidaInventarioHueco[Jugador.Inventario.Inventario.instancia.huecos.Length];

            int i = 0;
            while (i < Jugador.Inventario.Inventario.instancia.huecos.Length)
            {
                partida.inventario[i] = new PartidaInventarioHueco();

                if (Jugador.Inventario.Inventario.instancia.huecos[i] != null)
                {
                    partida.inventario[i].ocupado = true;

                    if (Jugador.Inventario.Inventario.instancia.huecos[i].objeto != null)
                    {
                        partida.inventario[i].objetoId = Jugador.Inventario.Inventario.instancia.huecos[i].objeto.id;
                        partida.inventario[i].cantidad = Jugador.Inventario.Inventario.instancia.huecos[i].cantidad;
                        partida.inventario[i].equipado = Canvas.Inventario.instancia.huecos[i].equipado;
                    }
                }
                else
                {
                    partida.inventario[i].ocupado = false;
                    continue;
                }

                i += 1;
            }

            return partida;
        }

        private Datos Objetos(Datos partida)
        {
            Objeto.Objeto[] objetos = FindObjectsOfType<Objeto.Objeto>();
            partida.objetosSueltos = new PartidaObjetoSuelto[objetos.Length];

            int i = 0;
            while (i < objetos.Length)
            {
                partida.objetosSueltos[i] = new PartidaObjetoSuelto
                {
                    id = objetos[i].objeto.id,
                    posicion = new VectorTres(objetos[i].transform.position),
                    rotacion = new VectorTres(objetos[i].transform.localEulerAngles)
                };

                i += 1;
            }

            return partida;
        }
    }
}

