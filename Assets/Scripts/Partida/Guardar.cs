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
                sueño = Jugador.Necesidades.instancia.sueño.valorActual,

                tiempoDia = Escenario.DiaNoche.instancia.tiempo
            };

            //------------------------------------------------

            partida = Escenario2(partida);
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

        private Datos Escenario2(Datos partida)
        {
            partida.escenario.casillasEscala = Escenario.Generar.Escenario.instancia.casillasEscala;
            partida.escenario.tamañoEscenarioX = Escenario.Generar.Escenario.instancia.tamañoEscenarioX;
            partida.escenario.tamañoEscenarioZ = Escenario.Generar.Escenario.instancia.tamañoEscenarioZ;

            return partida;
        }

        private Datos Casillas(Datos partida)
        {
            partida.casillas = new PartidaCasilla[Escenario.Generar.Escenario.instancia.casillas.Length];

            int i = 0;
            foreach (Assets.Casilla casilla in Escenario.Generar.Escenario.instancia.casillas)
            {
                if (casilla != null)
                {
                    partida.casillas[i] = new PartidaCasilla();
                    partida.casillas[i].idCasilla = casilla.id;
                
                    if (casilla.isla != null)
                    {
                        partida.casillas[i].idIsla = casilla.isla.id;
                    }
                    else
                    {
                        partida.casillas[i].idIsla = 9999;
                    }

                    partida.casillas[i].coordenadas = new VectorTres(casilla.posicion);
                    partida.casillas[i].rotacion = casilla.rotacion;

                    partida.casillas[i].recursoPuesto = casilla.recursoPuesto;

                    if (casilla.recursoPuesto == true)
                    {
                        partida.casillas[i].recurso.id = casilla.recursoID;
                        partida.casillas[i].recurso.posicion = new VectorTres(casilla.recursoPosicion);
                        partida.casillas[i].recurso.rotacion = new VectorTres(casilla.recurso.transform.localEulerAngles);

                        GameObject recurso = casilla.recurso;
                        Escenario.Recurso recurso2 = recurso.GetComponent<Escenario.Recurso>();
                        partida.casillas[i].recurso.cantidad = recurso2.cantidad;

                        if (recurso2.subrecursos != null)
                        {
                            partida.casillas[i].recurso.subrecursos = new bool[recurso2.subrecursos.Count];

                            int j = 0;
                            foreach (GameObject subrecurso in recurso2.subrecursos)
                            {
                                if (subrecurso != null)
                                {
                                    partida.casillas[i].recurso.subrecursos[j] = subrecurso.activeSelf;
                                }

                                j += 1;
                            }
                        }                        
                    }

                    i += 1;
                }               
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
            partida.objetos = new PartidaObjeto[objetos.Length];

            int i = 0;
            while (i < objetos.Length)
            {
                partida.objetos[i] = new PartidaObjeto
                {
                    id = objetos[i].objeto.id,
                    posicion = new VectorTres(objetos[i].transform.position),
                    rotacion = new VectorTres(objetos[i].transform.localEulerAngles)
                };

                Rigidbody cuerpo = objetos[i].transform.GetComponent<Rigidbody>();
                partida.objetos[i].fijo = cuerpo.isKinematic;

                i += 1;
            }

            return partida;
        }
    }
}

