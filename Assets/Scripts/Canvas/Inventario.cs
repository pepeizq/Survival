using TMPro;
using UnityEngine;

namespace Canvas
{
    public class Inventario : MonoBehaviour
    {
        public Jugador.Inventario.Hueco[] huecos;

        public TextMeshProUGUI nombre;
        public TextMeshProUGUI descripcion;
        public TextMeshProUGUI atributoNombre;
        public TextMeshProUGUI atributoValor;

        public GameObject botonUsar;
        public GameObject botonEquipar;
        public GameObject botonDesequipar;
        public GameObject botonSoltar;

        public static Inventario instancia;

        public void Awake()
        {
            instancia = this;
        }
    }
}