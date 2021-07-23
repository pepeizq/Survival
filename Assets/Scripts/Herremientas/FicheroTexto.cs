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

        public void Limpiar()
        {
            string ruta = Application.persistentDataPath + "/test.txt";

            StreamWriter escritor = new StreamWriter(ruta, false);
            escritor.Flush();
            escritor.Close();
        }

        public void Escribir(string texto)
        {
            string ruta = Application.persistentDataPath + "/test.txt";
   
            StreamWriter escritor = new StreamWriter(ruta, true);
            escritor.WriteLine(texto);
            escritor.Close();
        }

        public void Leer()
        {
            string path = Application.persistentDataPath + "/test.txt";

            StreamReader reader = new StreamReader(path);
            Debug.Log(reader.ReadToEnd());
            reader.Close();
        }
    }
}

