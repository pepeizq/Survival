using System;
using UnityEngine;

namespace Herramientas
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
            GUIUtility.systemCopyBuffer = null;
        }

        public void Texto(string texto)
        {
            GUIUtility.systemCopyBuffer = GUIUtility.systemCopyBuffer + texto + Environment.NewLine;
        }
    }
}

