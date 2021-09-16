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

            Limpieza();
            Casillas(partida);
            Inventario(partida);
            Objetos(partida);
          
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

            //------------------------------------------------

            //Enemigos.Enemigo[] enemigos = FindObjectsOfType<Enemigos.Enemigo>();

            //i = 0;
            //while (i < enemigos.Length)
            //{
            //    Destroy(enemigos[i].gameObject);

            //    i += 1;
            //}

            //i = 0;
            //while (i < partida.enemigos.Length)
            //{
            //    GameObject prefab = Gestor.instancia.ObtenerEnemigo(partida.enemigos[i].prefabId).prefab;
            //    GameObject enemigoObjeto = Instantiate(prefab, partida.enemigos[i].posicion.ObtenerVector3(), Quaternion.Euler(partida.enemigos[i].rotacion.ObtenerVector3()));
            //    Enemigos.Enemigo enemigo = enemigoObjeto.GetComponent<Enemigos.Enemigo>();

            //    enemigo.iaEstado = (Enemigos.IAEstado)partida.enemigos[i].iaEstado;
            //    enemigo.agente.isStopped = !partida.enemigos[i].intentaMoverse;

            //    if (enemigo.agente.isStopped == false)
            //    {
            //        enemigo.agente.SetDestination(partida.enemigos[i].posicionDestino.ObtenerVector3());
            //    }

            //    i += 1;
            //}
        }

        private void Limpieza()
        {
            Objeto.Objeto[] objetos = FindObjectsOfType<Objeto.Objeto>();

            int i = 0;
            while (i < objetos.Length)
            {
                Destroy(objetos[i].gameObject);

                i += 1;
            }
        }

        private void Casillas(Datos partida)
        {
            Escenario.Generar.Escenario.instancia.casillas = new Assets.Casilla[partida.escenario.tamañoEscenarioX, partida.escenario.tamañoEscenarioZ];

            int i = 0;
            while (i < partida.casillas.Length)
            {
                GameObject prefab = null;
                int idCasilla = 0;
                Assets.Isla isla = null;

                if (partida.casillas[i].idIsla != 9999)
                {
                    foreach (Assets.Isla isla2 in Gestor.instancia.islas)
                    {
                        if (partida.casillas[i].idIsla == isla2.id)
                        {
                            foreach (Assets.Casilla casilla in isla2.casillas)
                            {                              
                                if (partida.casillas[i].idCasilla == casilla.id)
                                {
                                    prefab = casilla.prefab;
                                    idCasilla = casilla.id;
                                    isla = isla2;
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
                
                if (prefab != null)
                {                 
                    Vector3 posicionFinal = partida.casillas[i].coordenadas.ObtenerVector3();
                    int x = (int)posicionFinal.x;
                    int z = (int)posicionFinal.z;

                    if (partida.escenario.casillasEscala != 0.5f)
                    {
                        posicionFinal.x = (posicionFinal.x + posicionFinal.x * (partida.escenario.casillasEscala * 1.5f)) - (partida.escenario.tamañoEscenarioX / (partida.escenario.casillasEscala + 0.5f));
                        posicionFinal.y = posicionFinal.y + posicionFinal.y * (partida.escenario.casillasEscala * 1.5f);
                        posicionFinal.z = (posicionFinal.z + posicionFinal.z * (partida.escenario.casillasEscala * 1.5f)) - (partida.escenario.tamañoEscenarioZ / (partida.escenario.casillasEscala + 0.5f));
                    }

                    GameObject casilla2 = Instantiate(prefab, posicionFinal, Quaternion.identity);
                    casilla2.gameObject.transform.Rotate(Vector3.up, partida.casillas[i].rotacion, Space.World);
                    casilla2.gameObject.transform.localScale = new Vector3(partida.escenario.casillasEscala, partida.escenario.casillasEscala, partida.escenario.casillasEscala);

                    Assets.Casilla casilla3 = new Assets.Casilla(idCasilla, partida.casillas[i].rotacion, partida.casillas[i].coordenadas.ObtenerVector3());
                    casilla3.id = idCasilla;
                    casilla3.prefab = casilla2;
                    casilla3.prefab.gameObject.layer = LayerMask.NameToLayer("Terreno");

                    Escenario.Generar.Escenario.instancia.casillas[x, z] = casilla3;

                    if (isla != null)
                    {
                        casilla3.isla = isla;

                        casilla3.recursoPuesto = partida.casillas[i].recursoPuesto;
                       
                        if (partida.casillas[i].recursoPuesto == true)
                        {
                            GameObject recurso1 = Instantiate(isla.recursos[partida.casillas[i].recurso.id]);
                            recurso1.transform.SetParent(Escenario.Generar.Escenario.instancia.casillas[x, z].prefab.transform);
                            recurso1.transform.localPosition = partida.casillas[i].recurso.posicion.ObtenerVector3();
                            recurso1.gameObject.transform.Rotate(partida.casillas[i].recurso.rotacion.ObtenerVector3(), Space.World);

                            Escenario.Recurso recurso2 = recurso1.GetComponent<Escenario.Recurso>();
                            recurso2.cantidad = partida.casillas[i].recurso.cantidad;

                            if (partida.casillas[i].recurso.subrecursos.Length > 0)
                            {
                                int j = 0;
                                while (j < recurso2.subrecursos.Count)
                                {
                                    if (recurso2.subrecursos[j] != null)
                                    {
                                        recurso2.subrecursos[j].SetActive(partida.casillas[i].recurso.subrecursos[j]);
                                    }

                                    j += 1;
                                }
                            }                          
                        }
                    }
                }

                i += 1;
            }
        }

        private void Inventario(Datos partida)
        {
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
                Jugador.Inventario.Inventario.instancia.EquiparBoton(true);
            }
        }

        private void Objetos(Datos partida)
        {
            int i = 0;
            while (i < partida.objetos.Length)
            {
                if (partida.objetos[i].fijo == false)
                {
                    GameObject prefab = Gestor.instancia.ObtenerObjeto(partida.objetos[i].id).prefab;
                    Instantiate(prefab, partida.objetos[i].posicion.ObtenerVector3(), Quaternion.Euler(partida.objetos[i].rotacion.ObtenerVector3()));
                }

                i += 1;
            }
        }
    }
}