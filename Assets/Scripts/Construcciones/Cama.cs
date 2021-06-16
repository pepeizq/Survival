using UnityEngine;

namespace Construccion
{
    public class Cama : Propiedades, IInteractuable
    {
        public float despertarHora;
        public float cuandoPuedeDormirPrincipioHora;
        public float cuandoPuedeDormirFinHora;
        public float sueñoQuitado;

        public string MensajeMostrar()
        {
            bool resultado = PuedeDormir();

            if (resultado == true)
            {
                return "Dormir";
            }
            else
            {
                return "No Puedes Dormir";
            }
        }

        public void Interactuar()
        {
            bool resultado = PuedeDormir();

            if (resultado == true)
            {
                DiaNoche.instancia.tiempo = despertarHora;
                Jugador.Necesidades.instancia.Dormir(sueñoQuitado);
            }
        }

        public bool PuedeDormir()
        {
            float hora = DiaNoche.instancia.tiempo;

            if (hora >= cuandoPuedeDormirPrincipioHora || hora <= cuandoPuedeDormirFinHora)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

