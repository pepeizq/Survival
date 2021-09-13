using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Partida
{
    public class Fichero : MonoBehaviour
    {
        public void Start()
        {
            //StartCoroutine(CargarPartida());
        }

        IEnumerator CargarPartida()
        {
            yield return new WaitForEndOfFrame();

            if (PlayerPrefs.HasKey("Guardar") == true)
            {
                Cargar();
            }
        }

        public void Update()
        {
            //if (Keyboard.current.nKey.wasPressedThisFrame == true)
            //{
            //    Guardar();
            //}

            //if (Keyboard.current.mKey.wasPressedThisFrame == true)
            //{
            //    Cargar();
            //}
        }

        public void Guardar()
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

            //------------------------------------------------

            Objeto.Objeto[] objetos = FindObjectsOfType<Objeto.Objeto>();
            partida.objetosSueltos = new PartidaObjetoSuelto[objetos.Length];

            i = 0;
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

            //------------------------------------------------

            Construccion.Propiedades[] construcciones = FindObjectsOfType<Construccion.Propiedades>();
            partida.construcciones = new PartidaConstruccion[construcciones.Length];

            i = 0;
            while (i < construcciones.Length)
            {
                partida.construcciones[i] = new PartidaConstruccion
                {
                    id = construcciones[i].asset.id,
                    posicion = new VectorTres(construcciones[i].asset.prefab.transform.position),
                    rotacion = new VectorTres(construcciones[i].asset.prefab.transform.localEulerAngles),
                    propiedades = construcciones[i].CogerPropiedades()
                };

                i += 1;
            }

            //------------------------------------------------

            partida.casillas = new PartidaCasilla[Gestor.instancia.casillas.Length];

            i = 0;
            while (i < Gestor.instancia.casillas.Length)
            {
                partida.casillas[i] = new PartidaCasilla();
                partida.casillas[i].idCasilla = Gestor.instancia.casillas[i].id;
                partida.casillas[i].idIsla = Gestor.instancia.casillas[i].isla.id;
                partida.casillas[i].coordenadas = new VectorTres(Gestor.instancia.casillas[i].posicion);

                i += 1;
            }

            //------------------------------------------------

            partida.recursos = new PartidaRecurso[Gestor.instancia.recursos.Length];

            i = 0;
            while (i < Gestor.instancia.recursos.Length)
            {
                partida.recursos[i] = new PartidaRecurso();
                partida.recursos[i].index = i;

                if (Gestor.instancia.recursos[i] == null)
                {
                    partida.recursos[i].destruido = true;
                }
                else
                {
                    partida.recursos[i].destruido = false;
                    partida.recursos[i].capacidad = Gestor.instancia.recursos[i].cantidad;
                }           

                i += 1;
            }

            //------------------------------------------------

            Enemigos.Enemigo[] enemigos = FindObjectsOfType<Enemigos.Enemigo>();
            partida.enemigos = new PartidaEnemigo[enemigos.Length];

            i = 0;
            while (i < enemigos.Length)
            {
                partida.enemigos[i] = new PartidaEnemigo
                {
                    prefabId = enemigos[i].asset.id,
                    posicion = new VectorTres(enemigos[i].asset.prefab.transform.position),
                    rotacion = new VectorTres(enemigos[i].asset.prefab.transform.localEulerAngles),
                    iaEstado = (int)enemigos[i].iaEstado,
                    intentaMoverse = !enemigos[i].agente.isStopped,
                    posicionDestino = new VectorTres(enemigos[i].agente.destination)
                };

                i += 1;
            }

            //------------------------------------------------

            string datos = JsonUtility.ToJson(partida);
            PlayerPrefs.SetString("Guardar", datos);
        }

        public void Cargar()
        {
            Datos partida = JsonUtility.FromJson<Datos>(PlayerPrefs.GetString("Guardar"));

            Jugador.Movimientos.instancia.transform.position = partida.jugadorPosicion.ObtenerVector3();
            Jugador.Movimientos.instancia.transform.eulerAngles = partida.jugadorRotacion.ObtenerVector3();
            Jugador.Movimientos.instancia.camaraContenedor.eulerAngles = partida.jugadorMirar.ObtenerVector3();

            Jugador.Necesidades.instancia.vida.valorActual = partida.vida;
            Jugador.Necesidades.instancia.hambre.valorActual = partida.hambre;
            Jugador.Necesidades.instancia.sed.valorActual = partida.sed;
            Jugador.Necesidades.instancia.sueño.valorActual = partida.sueño;

            Escenario.DiaNoche.instancia.tiempo = partida.tiempoDia;

            //------------------------------------------------

            int objetoEquipado = 99999;

            int i = 0;
            while (i < partida.inventario.Length)
            {
                if (partida.inventario[i].ocupado == false)
                {
                    continue;
                }
                else
                {
                    Jugador.Inventario.Inventario.instancia.huecos[i].objeto = Gestor.instancia.ObtenerObjeto(partida.inventario[i].objetoId);
                    Jugador.Inventario.Inventario.instancia.huecos[i].cantidad = partida.inventario[i].cantidad;

                    if (partida.inventario[i].equipado == true)
                    {
                        objetoEquipado = i;
                    }
                }

                i += 1;
            }

            if (objetoEquipado != 99999)
            {
                Jugador.Inventario.Inventario.instancia.SeleccionarObjeto(objetoEquipado);
                Jugador.Inventario.Inventario.instancia.EquiparBoton();
            }

            //------------------------------------------------

            Objeto.Objeto[] objetos = FindObjectsOfType<Objeto.Objeto>();

            i = 0;
            while (i < objetos.Length)
            {
                Destroy(objetos[i].gameObject);

                i += 1;
            }

            i = 0;
            while (i < partida.objetosSueltos.Length)
            {
                GameObject prefab = Gestor.instancia.ObtenerObjeto(partida.objetosSueltos[i].id).prefab;
                Instantiate(prefab, partida.objetosSueltos[i].posicion.ObtenerVector3(), Quaternion.Euler(partida.objetosSueltos[i].rotacion.ObtenerVector3()));

                i += 1;
            }

            //------------------------------------------------

            Construccion.Propiedades[] construcciones = FindObjectsOfType<Construccion.Propiedades>();

            i = 0;
            while (i < construcciones.Length)
            {
                Destroy(construcciones[i].gameObject);

                i += 1;
            }

            i = 0;
            while (i < partida.construcciones.Length)
            {
                GameObject prefab = Gestor.instancia.ObtenerConstruccion(partida.construcciones[i].id).prefab;
                GameObject construccion = Instantiate(prefab, partida.construcciones[i].posicion.ObtenerVector3(), Quaternion.Euler(partida.construcciones[i].rotacion.ObtenerVector3()));
                construccion.GetComponent<Construccion.Propiedades>().RecibirPropiedades(partida.construcciones[i].propiedades);

                i += 1;
            }

            //------------------------------------------------

            i = 0;
            while (i < Gestor.instancia.recursos.Length)
            {
                if (partida.recursos[i].destruido == true)
                {
                    Destroy(Gestor.instancia.recursos[i].gameObject);
                    continue;
                }
                else
                {
                    Gestor.instancia.recursos[i].cantidad = partida.recursos[i].capacidad;
                }

                i += 1;
            }

            //------------------------------------------------

            Enemigos.Enemigo[] enemigos = FindObjectsOfType<Enemigos.Enemigo>();

            i = 0;
            while (i < enemigos.Length)
            {
                Destroy(enemigos[i].gameObject);

                i += 1;
            }

            i = 0;
            while (i < partida.enemigos.Length)
            {
                GameObject prefab = Gestor.instancia.ObtenerEnemigo(partida.enemigos[i].prefabId).prefab;
                GameObject enemigoObjeto = Instantiate(prefab, partida.enemigos[i].posicion.ObtenerVector3(), Quaternion.Euler(partida.enemigos[i].rotacion.ObtenerVector3()));
                Enemigos.Enemigo enemigo = enemigoObjeto.GetComponent<Enemigos.Enemigo>();

                enemigo.iaEstado = (Enemigos.IAEstado)partida.enemigos[i].iaEstado;
                enemigo.agente.isStopped = !partida.enemigos[i].intentaMoverse;

                if (enemigo.agente.isStopped == false)
                {
                    enemigo.agente.SetDestination(partida.enemigos[i].posicionDestino.ObtenerVector3());
                }
               
                i += 1;
            }
        }
    }
}

