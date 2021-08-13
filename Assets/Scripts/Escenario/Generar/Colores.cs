using UnityEngine;

namespace Escenario.Generar
{
    public class Colores : MonoBehaviour
    {
        public static Colores instancia;

        public void Awake()
        {
            instancia = this;
        }

        //Verde             esquina 2 rotacion 180
        //Gris              esquina 2 rotacion 270
        //Marron Claro      esquina 2 rotacion 90 
        //Morado            esquina 2 rotacion 0

        //Rojo              rampa 1 rotacion 90
        //Marron Oscuro     rampa 1 rotacion 180
        //Blanco            rampa 1 rotacion 270
        //Amarillo          rampa 1 rotacion 0

        //-----------------------------------------------------------------------

        //Verde - esquina2rotacion180
        public void Casilla_Xmenos1_Zmenos1(int x, float y, int z)
        {
            Assets.Casilla rampas4rotacion90 = new Assets.Casilla(4, 90, new Vector3(x - 1, y, z - 1));
            rampas4rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z - 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z - 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z - 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            Assets.Casilla plano = new Assets.Casilla(0, 0, new Vector3(x - 1, y + 0.5f, z - 1));
            plano.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(3, 90, new Vector3(x - 1, y, z - 1));
            esquina3rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(3, 270, new Vector3(x - 1, y, z - 1));
            esquina3rotacion270.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(3, 180, new Vector3(x - 1, y, z - 1));
            esquina3rotacion180.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion90 = new Assets.Casilla(1, 90, new Vector3(x - 1, y, z - 1));
            rampa1rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion180 = new Assets.Casilla(1, 180, new Vector3(x - 1, y, z - 1));
            rampa1rotacion180.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion180 = new Assets.Casilla(2, 180, new Vector3(x - 1, y, z - 1));
            esquina2rotacion180.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion180);
            }
        }

        //Gris - esquina2rotacion270
        public void Casilla_Xmenos1_Zmas1(int x, float y, int z)
        {
            Assets.Casilla rampas4rotacion0 = new Assets.Casilla(39, 0, new Vector3(x - 1, y, z + 1));
            rampas4rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 2], y, 90) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 2], y, 90) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 2], y, 90) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x - 2, z]) == true && Escenario.instancia.ComprobarCasilla3(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Assets.Casilla plano = new Assets.Casilla(35, 0, new Vector3(x - 1, y + 0.5f, z + 1));
            plano.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(38, 180, new Vector3(x - 1, y, z + 1));
            esquina3rotacion180.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(38, 0, new Vector3(x - 1, y, z + 1));
            esquina3rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(38, 270, new Vector3(x - 1, y, z + 1));
            esquina3rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion270 = new Assets.Casilla(36, 270, new Vector3(x - 1, y, z + 1));
            rampa1rotacion270.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion180 = new Assets.Casilla(36, 180, new Vector3(x - 1, y, z + 1));
            rampa1rotacion180.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion270 = new Assets.Casilla(37, 270, new Vector3(x - 1, y, z + 1));
            esquina2rotacion270.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion270);
            }
        }

        //Marron Claro - esquina2rotacion90 
        public void Casilla_Xmas1_Zmenos1(int x, float y, int z)
        {
            Assets.Casilla rampas4rotacion0 = new Assets.Casilla(34, 0, new Vector3(x + 1, y, z - 1));
            rampas4rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y - 0.5f, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z - 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z - 1]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z - 1]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z - 1]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla3(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla3(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z - 1]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z - 2], y - 0.5f, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Assets.Casilla plano = new Assets.Casilla(30, 0, new Vector3(x + 1, y + 0.5f, z - 1));
            plano.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(33, 180, new Vector3(x + 1, y, z - 1));
            esquina3rotacion180.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z - 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(33, 0, new Vector3(x + 1, y, z - 1));
            esquina3rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(33, 90, new Vector3(x + 1, y, z - 1));
            esquina3rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z - 1]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z - 1]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z - 1]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z - 1]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z - 1]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion0 = new Assets.Casilla(31, 0, new Vector3(x + 1, y, z - 1));
            rampa1rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion90 = new Assets.Casilla(31, 90, new Vector3(x + 1, y, z - 1));
            rampa1rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion90 = new Assets.Casilla(32, 90, new Vector3(x + 1, y, z - 1));
            esquina2rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion90);
            }
        }

        //Morado - esquina2rotacion0
        public void Casilla_Xmas1_Zmas1(int x, float y, int z)
        {
            Assets.Casilla rampas4rotacion90 = new Assets.Casilla(29, 90, new Vector3(x + 1, y, z + 1));
            rampas4rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y - 0.5f, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z], y - 0.5f, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla3(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z + 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            Assets.Casilla plano = new Assets.Casilla(25, 0, new Vector3(x + 1, y + 0.5f, z + 1));
            plano.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z + 1]) == false && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z + 2]) == false)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(28, 0, new Vector3(x + 1, y, z + 1));
            esquina3rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == false && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == false && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(28, 90, new Vector3(x + 1, y, z + 1));
            esquina3rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z + 1]) == false && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z + 2]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x, z + 1]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(28, 270, new Vector3(x + 1, y, z + 1));
            esquina3rotacion270.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla3(Escenario.instancia.casillas[x + 2, z + 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z + 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z + 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z + 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 1, z + 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z + 1]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion270 = new Assets.Casilla(26, 270, new Vector3(x + 1, y, z + 1));
            rampa1rotacion270.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion0 = new Assets.Casilla(26, 0, new Vector3(x + 1, y, z + 1));
            rampa1rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion0 = new Assets.Casilla(27, 0, new Vector3(x + 1, y, z + 1));
            esquina2rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion0);
            }
        }

        //Rojo - rampa1rotacion90
        public void Casilla_X0_Zmenos1(int x, float y, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(20, 0, new Vector3(x, y + 0.5f, z - 1));
            plano.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(23, 90, new Vector3(x, y, z - 1));
            esquina3rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(23, 180, new Vector3(x, y, z - 1));
            esquina3rotacion180.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion90 = new Assets.Casilla(21, 90, new Vector3(x, y, z - 1));
            rampa1rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
        }

        //Marron Oscuro - rampa1rotacion180
        public void Casilla_Xmenos1_Z0(int x, float y, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(5, 0, new Vector3(x - 1, y + 0.5f, z));
            plano.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(8, 270, new Vector3(x - 1, y, z));
            esquina3rotacion270.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(8, 180, new Vector3(x - 1, y, z));
            esquina3rotacion180.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion180 = new Assets.Casilla(6, 180, new Vector3(x - 1, y, z));
            rampa1rotacion180.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
        }

        //Blanco - rampa1rotacion270
        public void Casilla_X0_Zmas1(int x, float y, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(10, 0, new Vector3(x, y + 0.5f, z + 1));
            plano.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(13, 0, new Vector3(x, y, z + 1));
            esquina3rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(13, 270, new Vector3(x, y, z + 1));
            esquina3rotacion270.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion270 = new Assets.Casilla(11, 270, new Vector3(x, y, z + 1));
            rampa1rotacion270.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
        }

        //Amarillo - rampa1rotacion0
        public void Casilla_Xmas1_Z0(int x, float y, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(15, 0, new Vector3(x + 1, y + 0.5f, z));
            plano.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == false)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == false)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillas[x + 2, z]) == false)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(18, 0, new Vector3(x + 1, y, z));
            esquina3rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(18, 90, new Vector3(x + 1, y, z));
            esquina3rotacion90.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion0 = new Assets.Casilla(16, 0, new Vector3(x + 1, y, z));
            rampa1rotacion0.isla = ObtenerIsla(Escenario.instancia.casillas[x, z]);

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillas[x, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
        }

        //-----------------------------------------------------------------------

        private Assets.Isla ObtenerIsla(Assets.Casilla casillaOrigen)
        {
            if (casillaOrigen != null)
            {
                if (casillaOrigen.isla != null)
                {
                    return casillaOrigen.isla;
                }
            }

            return null;
        }
    }
}