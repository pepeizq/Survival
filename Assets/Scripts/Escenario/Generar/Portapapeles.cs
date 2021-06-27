using System;
using UnityEngine;

namespace Escenario.Generar
{
    public class Portapapeles : MonoBehaviour
    {
        public static Portapapeles instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Limpiar()
        {
            if (Escenario.instancia.portapapeles == true)
            {
                GUIUtility.systemCopyBuffer = null;
            }
        }

        public void Texto(string texto)
        {
            if (Escenario.instancia.portapapeles == true)
            {
                GUIUtility.systemCopyBuffer = GUIUtility.systemCopyBuffer + texto + Environment.NewLine;
            }
        }

        public void Vector3(Vector3 vector)
        {
            if (Escenario.instancia.portapapeles == true)
            {
                string y = vector.y.ToString("0.00");
                y = y.Replace(",00", null);
                y = y.Replace(",50", ".5f");
                y = y.Replace(",25", ".25f");

                GUIUtility.systemCopyBuffer = GUIUtility.systemCopyBuffer + "new Vector3(" + vector.x.ToString() + ", " + y + ", " + vector.z.ToString() + ")," + Environment.NewLine;
            }
        }
    }
}

