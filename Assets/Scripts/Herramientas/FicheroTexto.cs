using System.IO;
using UnityEngine;

namespace Herramientas
{
    public class FicheroTexto : MonoBehaviour
    {
        public static FicheroTexto instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Limpiar(string nombreFichero)
        {
            string ruta = Application.persistentDataPath + "/" + nombreFichero + ".txt";

            StreamWriter escritor = new StreamWriter(ruta, false);
            escritor.Flush();
            escritor.Close();
        }

        public void Escribir(string texto, string nombreFichero)
        {
            string ruta = Application.persistentDataPath + "/" + nombreFichero + ".txt";

            StreamWriter escritor = new StreamWriter(ruta, true);
            escritor.WriteLine(texto);
            escritor.Close();
        }

        public void Leer(string nombreFichero)
        {
            string ruta = Application.persistentDataPath + "/" + nombreFichero + ".txt";

            StreamReader lector = new StreamReader(ruta);
            Debug.Log(lector.ReadToEnd());
            lector.Close();
        }
    }
}

