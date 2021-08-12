using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Escenario.Generar
{
    public class Escenario : MonoBehaviour
    {
        [Header("Opciones")]
        public bool aleatorio;
        public bool coloresGeneracion;
        public bool ponerLlano;
        public bool agua;
        public bool colocarJugador;

        [Header("Casillas")]
        public Assets.Casilla[] casillasDebug;
        public Assets.Isla[] islas;

        [HideInInspector]
        public Assets.Casilla[,] casillas = new Assets.Casilla[1, 1];

        [HideInInspector]
        public int tamañoEscenarioX = 0;

        [HideInInspector]
        public int tamañoEscenarioZ = 0;

        [HideInInspector]
        public float casillasEscala = 1f;

        [HideInInspector]
        public int limitesMapa = 3;

        public static Escenario instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Start()
        {
            int alturaMaxima = 1;

            foreach (Assets.Isla isla in islas)
            {
                if (isla.alturaMaxima > alturaMaxima)
                {
                    alturaMaxima = (int)isla.alturaMaxima;
                }

                tamañoEscenarioX = tamañoEscenarioX + (int)isla.extensionMaxima.x * 3;
                tamañoEscenarioZ = tamañoEscenarioZ + (int)isla.extensionMaxima.y * 3;
            }

            casillas = new Assets.Casilla[tamañoEscenarioX, tamañoEscenarioZ];

            if (aleatorio == true)
            {
                Vectores.instancia.GenerarCasillas(casillas, islas, limitesMapa);
            }

            int k = 0;
            float altura = alturaMaxima;
            int tope = (int)alturaMaxima * 2;
            while (k < tope)
            {
                altura -= 0.5f;

                if (altura <= 1f)
                {
                    break;
                }

                try
                {
                    GenerarNivel(altura);
                }
                catch (Exception fallo)
                {
                    Debug.Log(fallo);
                    k -= 1;
                }

                k += 1;
            }

            //----------------------------------------------------------

            if (ponerLlano == true)
            {
                Llano.instancia.Generar(casillas, islas, altura);
            }

            if (agua == true)
            {
                altura -= 0.5f;
                Agua.instancia.Generar(casillas, altura);
            }

            if (colocarJugador == true)
            {
                ColocarJugador2();
            }
        }

        public void Update()
        {

        }

        //------------------------------------------------------------------------------------------------------------------------------------

        private void GenerarNivel(float altura)
        {
            foreach (Assets.Isla isla in islas)
            {
                CargarGuardar.Isla isla2 = Vectores.instancia.LeerDatos(isla.id);

                foreach (CargarGuardar.PartidaEscenarioCasilla casilla in isla2.casillas)
                {
                    Vector3 casilla2 = casilla.coordenadas.ObtenerVector3();

                    if (altura == casilla2.y)
                    {
                        if (Limites.Comprobar((int)casilla2.x, 3, tamañoEscenarioX) == true && Limites.Comprobar((int)casilla2.z, 3, tamañoEscenarioZ) == true)
                        {
                            if (casillas[(int)casilla2.x, (int)casilla2.z] == null)
                            {
                                Assets.Casilla casilla3 = new Assets.Casilla(0, 0, casilla2)
                                {
                                    isla = isla
                                };

                                PonerCasilla(casilla3);
                            }
                        }
                    }
                }
            }

            foreach (Assets.Casilla subcasilla in casillas)
            {
                if (subcasilla != null)
                {
                    int x = (int)subcasilla.posicion.x;
                    int z = (int)subcasilla.posicion.z;

                    float y = subcasilla.posicion.y;
                    y = y - 0.5f;

                    if (y < 0.0f)
                    {
                        y = 0.0f;
                    }

                    if ((y > 0) && (altura == subcasilla.posicion.y) && Limites.Comprobar(x, 2, tamañoEscenarioX) == true && Limites.Comprobar(z, 2, tamañoEscenarioZ) == true)
                    {
                        if (casillas[x - 1, z - 1] == null)
                        {
                            Colores.instancia.Casilla_Xmenos1_Zmenos1(x, y, z);
                        }

                        if (casillas[x - 1, z + 1] == null)
                        {
                            Colores.instancia.Casilla_Xmenos1_Zmas1(x, y, z);
                        }

                        if (casillas[x + 1, z - 1] == null)
                        {
                            Colores.instancia.Casilla_Xmas1_Zmenos1(x, y, z);
                        }

                        if (casillas[x + 1, z + 1] == null)
                        {
                            Colores.instancia.Casilla_Xmas1_Zmas1(x, y, z);
                        }

                        if (casillas[x, z - 1] == null)
                        {
                            Colores.instancia.Casilla_X0_Zmenos1(x, y, z);
                        }

                        if (casillas[x - 1, z] == null)
                        {
                            Colores.instancia.Casilla_Xmenos1_Z0(x, y, z);
                        }

                        if (casillas[x, z + 1] == null)
                        {
                            Colores.instancia.Casilla_X0_Zmas1(x, y, z);
                        }

                        if (casillas[x + 1, z] == null)
                        {
                            Colores.instancia.Casilla_Xmas1_Z0(x, y, z);
                        }
                    }
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------

        private void GenerarAgua(List<Vector3> listadoAguaInicial)
        {
            foreach (Vector3 casillaInicial in listadoAguaInicial.ToList<Vector3>())
            {
                if (Limites.Comprobar((int)casillaInicial.x, 3, (int)tamañoEscenarioX) == true && Limites.Comprobar((int)casillaInicial.z, 3, (int)tamañoEscenarioZ) == true)
                {
                    if (casillas[(int)casillaInicial.x, (int)casillaInicial.z] == null)
                    {
                        PonerCasilla(new Assets.Casilla(40, 0, casillaInicial));
                        listadoAguaInicial.Remove(casillaInicial);
                    }
                }
            }

            foreach (Assets.Casilla subcasilla in casillas)
            {
                if (subcasilla != null)
                {
                    if (subcasilla.id == 5)
                    {
                        int x = (int)subcasilla.posicion.x;
                        int z = (int)subcasilla.posicion.z;

                        if (Limites.Comprobar(x, 2, tamañoEscenarioX) == true && Limites.Comprobar(z, 2, tamañoEscenarioZ) == true)
                        {
                            if (casillas[x - 1, z - 1] == null)
                            {
                                CalcularAgua_Xmenos1_Zmenos1(x, z);
                            }

                            if (casillas[x + 1, z + 1] == null)
                            {
                                CalcularAgua_Xmas1_Zmas1(x, z);
                            }

                            if (casillas[x - 1, z + 1] == null)
                            {
                                CalcularAgua_Xmenos1_Zmas1(x, z);
                            }

                            if (casillas[x + 1, z - 1] == null)
                            {
                                CalcularAgua_Xmas1_Zmenos1(x, z);
                            }

                            if (casillas[x, z - 1] == null)
                            {
                                CalcularAgua_X0_Zmenos1(x, z);
                            }

                            if (casillas[x, z + 1] == null)
                            {
                                CalcularAgua_X0_Zmas1(x, z);
                            }

                            if (casillas[x - 1, z] == null)
                            {
                                CalcularAgua_Xmenos1_Z0(x, z);
                            }

                            if (casillas[x + 1, z] == null)
                            {
                                CalcularAgua_Xmas1_Z0(x, z);
                            }
                        }
                    }
                }
            }
        }

        private void CalcularAgua_Xmenos1_Zmenos1(int x, int z)
        {
            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(43, 0, new Vector3(x - 1, 0, z - 1));

            if (ComprobarVacio(casillas[x - 1, z]) == true && ComprobarVacio(casillas[x, z - 1]) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarAgua2(x - 1, z, 0) == true && ComprobarVacio(casillas[x, z - 1]) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
        }

        private void CalcularAgua_Xmas1_Zmas1(int x, int z)
        {
            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(43, 180, new Vector3(x + 1, 0, z + 1));

            if (ComprobarVacio(casillas[x + 1, z]) == true && ComprobarVacio(casillas[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarAgua2(x + 1, z, 180) == true && ComprobarVacio(casillas[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarVacio(casillas[x + 1, z]) == true && ComprobarAgua2(x, z + 1, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion180 = new Assets.Casilla(42, 180, new Vector3(x + 1, 0, z + 1));

            if (ComprobarAgua0(x + 1, z) == true && ComprobarAgua0(x, z + 1) == true && ComprobarAgua0(x + 1, z + 2) == false)
            {
                PonerCasilla(esquina2rotacion180);
            }
        }

        private void CalcularAgua_Xmenos1_Zmas1(int x, int z)
        {
            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(43, 90, new Vector3(x - 1, 0, z + 1));

            if (ComprobarVacio(casillas[x - 1, z]) == true && ComprobarVacio(casillas[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarAgua2(x - 1, z, 90) == true && ComprobarVacio(casillas[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
        }

        private void CalcularAgua_Xmas1_Zmenos1(int x, int z)
        {
            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(43, 270, new Vector3(x + 1, 0, z - 1));

            if (ComprobarVacio(casillas[x + 1, z]) == true && ComprobarVacio(casillas[x, z - 1]) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarVacio(casillas[x + 1, z]) == true && ComprobarAgua2(x, z - 1, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
        }

        private void CalcularAgua_X0_Zmenos1(int x, int z)
        {
            Assets.Casilla esquina2rotacion0 = new Assets.Casilla(42, 0, new Vector3(x, 0, z - 1));

            if (ComprobarAgua0(x + 1, z - 1) == true)
            {
                PonerCasilla(esquina2rotacion0);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion270 = new Assets.Casilla(41, 270, new Vector3(x, 0, z - 1));

            PonerCasilla(rampa1rotacion270);
        }

        private void CalcularAgua_X0_Zmas1(int x, int z)
        {
            Assets.Casilla esquina2rotacion90 = new Assets.Casilla(42, 90, new Vector3(x, 0, z + 1));

            if (ComprobarAgua0(x + 1, z + 1) == true && ComprobarVacio(casillas[x - 1, z + 2]) == true)
            {
                PonerCasilla(esquina2rotacion90);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion90 = new Assets.Casilla(41, 90, new Vector3(x, 0, z + 1));

            PonerCasilla(rampa1rotacion90);
        }

        private void CalcularAgua_Xmenos1_Z0(int x, int z)
        {
            Assets.Casilla rampa1rotacion0 = new Assets.Casilla(41, 0, new Vector3(x - 1, 0, z));

            PonerCasilla(rampa1rotacion0);
        }

        private void CalcularAgua_Xmas1_Z0(int x, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(40, 0, new Vector3(x + 1, 0.25f, z));

            if (ComprobarAgua0(x + 1, z - 1) == true && ComprobarAgua0(x + 1, z + 1) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion270 = new Assets.Casilla(42, 270, new Vector3(x + 1, 0, z));

            if (ComprobarAgua0(x + 1, z + 1) == true && ComprobarVacio(casillas[x + 2, z - 1]) == true)
            {
                PonerCasilla(esquina2rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion180 = new Assets.Casilla(41, 180, new Vector3(x + 1, 0, z));

            PonerCasilla(rampa1rotacion180);
        }

        //------------------------------------------------------------------------------------------------------------------------------------

        public void PonerCasilla(Assets.Casilla casilla)
        {
            Assets.Casilla[] casillasFinal;
            int id = casilla.id;
            int idDebug = casilla.idDebug;

            if (coloresGeneracion == false)
            {
                if (id != 0 && id != casillasDebug.Length - 1)
                {
                    id = CalcularIDFinal(id);
                }
                
                if (casilla.isla != null)
                {
                    casillasFinal = casilla.isla.casillas;                 
                }
                else
                {
                    casillasFinal = casillasDebug;
                }
            }
            else
            {
                casillasFinal = casillasDebug;
                id = casilla.id;
                idDebug = casilla.id;
            }

            int x = (int)casilla.posicion.x;
            int z = (int)casilla.posicion.z;

            if (Limites.Comprobar(x, 3, tamañoEscenarioX) == true && Limites.Comprobar(z, 3, tamañoEscenarioZ) == true)
            {
                if (casillas[x, z] == null)
                {
                    Vector3 posicionFinal = casilla.posicion;

                    if (casillasEscala != 0.5f)
                    {
                        posicionFinal.x = (posicionFinal.x + posicionFinal.x * (casillasEscala * 1.5f)) - (tamañoEscenarioX / (casillasEscala + 0.5f));
                        posicionFinal.y = posicionFinal.y + posicionFinal.y * (casillasEscala * 1.5f);
                        posicionFinal.z = (posicionFinal.z + posicionFinal.z * (casillasEscala * 1.5f)) - (tamañoEscenarioZ / (casillasEscala + 0.5f));
                    }

                    GameObject casilla2 = Instantiate(casillasFinal[id].prefab, posicionFinal, Quaternion.identity);
                    casilla2.gameObject.transform.Rotate(Vector3.up, casilla.rotacion, Space.World);
                    casilla2.gameObject.transform.localScale = new Vector3(casillasEscala, casillasEscala, casillasEscala);

                    Assets.Casilla casilla3 = new Assets.Casilla(id, casilla.rotacion, casilla.posicion);
                    casilla3.id = id;
                    casilla3.idDebug = idDebug;
                    casilla3.prefab = casilla2;
                    casilla3.isla = casilla.isla;

                    casillas[x, z] = casilla3;
                }
            }
        }

        private int CalcularIDFinal(int id)
        {
            if (id >= 5 && id <= 9)
            {
                id = id - 5;
            }
            else if (id >= 10 && id <= 14)
            {
                id = id - 10;
            }
            else if (id >= 15 && id <= 19)
            {
                id = id - 15;
            }
            else if (id >= 20 && id <= 24)
            {
                id = id - 20;
            }
            else if (id >= 25 && id <= 29)
            {
                id = id - 25;
            }
            else if (id >= 30 && id <= 34)
            {
                id = id - 30;
            }
            else if (id >= 34 && id <= 39)
            {
                id = id - 35;
            }
            else if (id >= 40 && id <= 44)
            {
                id = id - 35;
            }

            return id;
        }

        public bool ComprobarCasilla0(Assets.Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 0)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 0)
                                {
                                    return true;
                                }
                            }                            
                        }
                    }
                }
            }

            return false;
        }

        public bool ComprobarCasilla1(Assets.Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 1)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool ComprobarCasilla2(Assets.Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 2)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 2)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool ComprobarCasilla3(Assets.Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 3)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 3)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool ComprobarVacio(Assets.Casilla casilla)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, 3) == true && ComprobarLimiteZ((int)casilla.posicion.z, 3) == true)
                {
                    if (casillas[(int)casilla.posicion.x, (int)casilla.posicion.z] != null)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool ComprobarAgua0(int x, int z)
        {
            if (ComprobarLimiteX(x, limitesMapa) == true && ComprobarLimiteZ(z, limitesMapa) == true)
            {
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].id == 5)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ComprobarAgua1(int x, int z, int rotacion)
        {
            if (ComprobarLimiteX(x, limitesMapa) == true && ComprobarLimiteZ(z, limitesMapa) == true)
            {
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].id == 6 && casillas[x, z].rotacion == rotacion)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ComprobarAgua2(int x, int z, int rotacion)
        {
            if (ComprobarLimiteX(x, limitesMapa) == true && ComprobarLimiteZ(z, limitesMapa) == true)
            {
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].id == 7 && casillas[x, z].rotacion == rotacion)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ComprobarAgua3(int x, int z, int rotacion)
        {
            if (ComprobarLimiteX(x, limitesMapa) == true && ComprobarLimiteZ(z, limitesMapa) == true)
            {
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].id == 8 && casillas[x, z].rotacion == rotacion)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ComprobarLimiteX(int x, int ajuste)
        {
            if ((x - ajuste >= 0) && (x + ajuste <= tamañoEscenarioX))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ComprobarLimiteZ(int z, int ajuste)
        {
            if ((z - ajuste >= 0) && (z + ajuste <= tamañoEscenarioZ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ColocarJugador2()
        {
            int x = ((int)islas[0].coordenadasMinimas.x + (int)islas[0].extensionMaxima.x) / 2;
            int z = ((int)islas[0].coordenadasMinimas.y + (int)islas[0].extensionMaxima.y) / 2;

            if (casillas[x, z] != null)
            {
                Vector3 posicion = casillas[x, z].posicion;
                float altura = 1.5f;
                
                if (casillas[x, z].id != 0)
                {
                    altura = 3f;
                }

                if (casillasEscala != 0.5f)
                {
                    posicion.y = altura + posicion.y + posicion.y * (casillasEscala * 1.5f);
                }
           
                Jugador.Movimientos.instancia.transform.position = posicion;
            }         
        }
    }
}

