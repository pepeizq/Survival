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
                        bool ocupado = false;

                        ocupado = VerificarRampa1Rotacion90(x, z, altura, casillas);

                        if (ocupado == false)
                        {
                            Assets.Casilla plano = new Assets.Casilla(Escenario.instancia.casillasDebug.Length - 1, 0, new Vector3(x, altura, z));
                            Escenario.instancia.PonerCasilla(plano);
                        }                        
                    }
                }
            }
        }

        private bool VerificarRampa1Rotacion90(int x, int z, float altura, Assets.Casilla[,] casillas)
        {
            //if (Limites.Comprobar(x - 1, 2, Escenario.instancia.tamañoEscenarioX) == true &&
            //    Limites.Comprobar(x + 1, 2, Escenario.instancia.tamañoEscenarioX) == true &&
            //    Limites.Comprobar(z - 1, 2, Escenario.instancia.tamañoEscenarioZ) == true &&
            //    Limites.Comprobar(z + 1, 2, Escenario.instancia.tamañoEscenarioZ) == true)
            //{
            //    if (casillas[x - 1, z] != null &&
            //        casillas[x - 1, z - 1] == null && casillas[x - 1, z + 1] == null && casillas[x, z + 1] == null && casillas[x, z - 1] == null &&
            //        casillas[x + 1, z + 1] == null && casillas[x + 1, z - 1] == null && casillas[x + 1, z] == null)
            //    {
            //        Assets.Isla isla = casillas[x - 1, z].isla;

            //        Assets.Casilla rampa = new Assets.Casilla(isla.casillas[5].id, 0, new Vector3(x, altura, z));
            //        rampa.isla = isla;
            //        Escenario.instancia.PonerCasilla(rampa);

            //        return true;
            //    }
            //}

            if (Limites.Comprobar(x + 1, 2, Escenario.instancia.tamañoEscenarioX) == true)
            {
                if (casillas[x + 1, z] != null)
                {
                    Assets.Isla isla = casillas[x + 1, z].isla;
              
                    Assets.Casilla rampa = new Assets.Casilla(6, 90, new Vector3(x, altura, z));
                    rampa.isla = isla;
                    Escenario.instancia.PonerCasilla(rampa);

                    return true;
                }
            }

            return false;
        }
    }
}

