using UnityEngine;

namespace Partida
{
    public class Cargar : MonoBehaviour
    {
        public static Cargar instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarDatos()
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

            Casillas(partida);

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

            //Construccion.Propiedades[] construcciones = FindObjectsOfType<Construccion.Propiedades>();

            //i = 0;
            //while (i < construcciones.Length)
            //{
            //    Destroy(construcciones[i].gameObject);

            //    i += 1;
            //}

            //i = 0;
            //while (i < partida.construcciones.Length)
            //{
            //    GameObject prefab = Gestor.instancia.ObtenerConstruccion(partida.construcciones[i].id).prefab;
            //    GameObject construccion = Instantiate(prefab, partida.construcciones[i].posicion.ObtenerVector3(), Quaternion.Euler(partida.construcciones[i].rotacion.ObtenerVector3()));
            //    construccion.GetComponent<Construccion.Propiedades>().RecibirPropiedades(partida.construcciones[i].propiedades);

            //    i += 1;
            //}

            //------------------------------------------------

            //i = 0;
            //while (i < Gestor.instancia.recursos.Length)
            //{
            //    if (partida.recursos[i].destruido == true)
            //    {
            //        Destroy(Gestor.instancia.recursos[i].gameObject);
            //        continue;
            //    }
            //    else
            //    {
            //        Gestor.instancia.recursos[i].cantidad = partida.recursos[i].capacidad;
            //    }

            //    i += 1;
            //}

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

        private void Casillas(Datos partida)
        {
            int i = 0;
            while (i < partida.casillas.Length)
            {
                GameObject prefab = new GameObject();
                int idCasilla = 0;
                Assets.Isla isla = null;

                if (partida.casillas[i].idIsla != 9999)
                {
                    foreach (Assets.Isla isla2 in Gestor.instancia.islas)
                    {
                        if (partida.casillas[i].idIsla == isla.id)
                        {
                            foreach (Assets.Casilla casilla in isla.casillas)
                            {
                                if (partida.casillas[i].idCasilla == casilla.id)
                                {
                                    prefab = casilla.prefab;
                                    idCasilla = casilla.id;
                                    isla = casilla.isla;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Assets.Casilla agua = Escenario.Generar.Escenario.instancia.casillasDebug[Escenario.Generar.Escenario.instancia.casillasDebug.Length - 1];
                    prefab = agua.prefab;
                    idCasilla = agua.id;
                }
                
                GameObject casilla2 = Instantiate(prefab, partida.casillas[i].coordenadas.ObtenerVector3(), Quaternion.identity);
                casilla2.gameObject.transform.Rotate(Vector3.up, partida.casillas[i].rotacion, Space.World);

                Assets.Casilla casilla3 = new Assets.Casilla(idCasilla, partida.casillas[i].rotacion, partida.casillas[i].coordenadas.ObtenerVector3());
                casilla3.id = idCasilla;
                casilla3.prefab = casilla2;
                casilla3.prefab.gameObject.layer = LayerMask.NameToLayer("Terreno");

                if (isla != null)
                {
                    casilla3.isla = isla;
                }
             
                //casilla3.recursoPuesto = false;
                //casilla3.recursoPosible = casillasFinal[id].recursoPosible;
                //casilla3.recursoPosicion = casillasFinal[id].recursoPosicion;
                //casilla3.construido = false;

                //casillas[x, z] = casilla3;

                i += 1;
            }
        }
    }
}