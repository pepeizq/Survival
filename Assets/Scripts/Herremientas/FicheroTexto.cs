using System.IO;
using UnityEngine;

namespace Herramientas
{
    public class FicheroTexto : MonoBehaviour
    {
        public static FicheroTexto instancia;

        //https://support.unity.com/hc/en-us/articles/115000341143-How-do-I-read-and-write-data-from-a-text-file-

        public void Awake()
        {
            instancia = this;
        }

        public void Limpiar()
        {
            string path = Application.persistentDataPath + "/test.txt";

            StreamWriter writer = new StreamWriter(path, false);
            writer.WriteLine("Vacio");
            writer.Close();
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

