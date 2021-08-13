using UnityEngine;

namespace Escenario.Generar
{
    public class Agua : MonoBehaviour
    {
        public static Agua instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Generar(Assets.Casilla[,] casillas, float altura)
        {
            for (int x = 0; x < casillas.GetLength(0); x++)
            {
                for (int z = 0; z < casillas.GetLength(1); z++)
                {
                    if (casillas[x, z] == null)
                    {
                        int ocupado = 0;

                        //-------------------------------------

                        if (ocupado == 0)
                        {
                            ocupado += VerificarEsquina2Rotacion180(x, z, altura, casillas);
                        }

                        //-------------------------------------

                        if (ocupado == 0)
                        {
                            ocupado += VerificarRampa1Rotacion180(x, z, altura, casillas);
                        }

                        if (ocupado == 0)
                        {
                            ocupado += VerificarRampa1Rotacion0(x, z, altura, casillas);
                        }

                        if (ocupado == 0)
                        {
                            ocupado += VerificarRampa1Rotacion270(x, z, altura, casillas);
                        }

                        if (ocupado == 0)
                        {
                            ocupado += VerificarRampa1Rotacion90(x, z, altura, casillas);
                        }

                        //-------------------------------------

                        if (ocupado == 0)
                        {
                            Assets.Casilla plano = new Assets.Casilla(Escenario.instancia.casillasDebug.Length - 1, 0, new Vector3(x, altura + 0.25f, z));
                            Escenario.instancia.PonerCasilla(plano);
                        }                        
                    }
                }
            }
        }

        //-------------------------------------

        private int VerificarEsquina2Rotacion180(int x, int z, float altura, Assets.Casilla[,] casillas)
        {
            if (Limites.Comprobar(x + 1, 2, Escenario.instancia.tamañoEscenarioX) == true && Limites.Comprobar(z + 1, 2, Escenario.instancia.tamañoEscenarioZ) == true)
            {
                if (casillas[x + 1, z + 1] != null && casillas[x + 1, z] == null && casillas[x, z + 1] == null)
                {
                    if (casillas[x + 1, z + 1].id < 5 && casillas[x + 1, z + 1].idDebug != 99)
                    {
                        Assets.Isla isla = casillas[x + 1, z + 1].isla;

                        Assets.Casilla esquina = new Assets.Casilla(6, 180, new Vector3(x, altura, z));
                        esquina.isla = isla;
                        esquina.idDebug = 99;
                        Escenario.instancia.PonerCasilla(esquina);

                        return 1;
                    }
                }
            }

            return 0;
        }

        //-------------------------------------

        private int VerificarRampa1Rotacion180(int x, int z, float altura, Assets.Casilla[,] casillas)
        {
            if (Limites.Comprobar(x + 1, 2, Escenario.instancia.tamañoEscenarioX) == true)
            {
                if (casillas[x + 1, z] != null)
                {
                    if (casillas[x + 1, z].id < 5 && casillas[x + 1, z].idDebug != 99)
                    {
                        Assets.Isla isla = casillas[x + 1, z].isla;

                        Assets.Casilla rampa = new Assets.Casilla(5, 180, new Vector3(x, altura, z));
                        rampa.isla = isla;
                        rampa.idDebug = 99;
                        Escenario.instancia.PonerCasilla(rampa);

                        return 1;
                    }                      
                }
            }

            return 0;
        }

        private int VerificarRampa1Rotacion0(int x, int z, float altura, Assets.Casilla[,] casillas)
        {
            if (Limites.Comprobar(x - 1, 2, Escenario.instancia.tamañoEscenarioX) == true)
            {
                if (casillas[x - 1, z] != null)
                {                   
                    if (casillas[x - 1, z].id < 5 && casillas[x - 1, z].idDebug != 99)
                    {
                        Assets.Isla isla = casillas[x - 1, z].isla;
                     
                        Assets.Casilla rampa = new Assets.Casilla(5, 0, new Vector3(x, altura, z));
                        rampa.isla = isla;
                        rampa.idDebug = 99;
                        Escenario.instancia.PonerCasilla(rampa);

                        return 1;
                    }                 
                }
            }
                
            return 0;
        }

        private int VerificarRampa1Rotacion90(int x, int z, float altura, Assets.Casilla[,] casillas)
        {
            if (Limites.Comprobar(z + 1, 2, Escenario.instancia.tamañoEscenarioZ) == true)
            {
                if (casillas[x, z + 1] != null)
                {
                    if (casillas[x, z + 1].id < 5 && casillas[x, z + 1].idDebug != 99)
                    {
                        Assets.Isla isla = casillas[x, z + 1].isla;

                        Assets.Casilla rampa = new Assets.Casilla(5, 90, new Vector3(x, altura, z));
                        rampa.isla = isla;
                        rampa.idDebug = 99;
                        Escenario.instancia.PonerCasilla(rampa);

                        return 1;
                    }
                }
            }

            return 0;
        }

        private int VerificarRampa1Rotacion270(int x, int z, float altura, Assets.Casilla[,] casillas)
        {
            if (Limites.Comprobar(z - 1, 2, Escenario.instancia.tamañoEscenarioZ) == true)
            {
                if (casillas[x, z - 1] != null)
                {
                    if (casillas[x, z - 1].id < 5 && casillas[x, z - 1].idDebug != 99)
                    {
                        Assets.Isla isla = casillas[x, z - 1].isla;

                        Assets.Casilla rampa = new Assets.Casilla(5, 270, new Vector3(x, altura, z));
                        rampa.isla = isla;
                        rampa.idDebug = 99;
                        Escenario.instancia.PonerCasilla(rampa);

                        return 1;
                    }
                }
            }

            return 0;
        }
    }
}

