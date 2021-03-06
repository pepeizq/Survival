using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Objeto", menuName = "Assets/Objeto")]
    public class Objeto : ScriptableObject
    {
        public string id;

        [Header("Datos")]
        public string nombre;
        public string descripcion;
        public Tipos.Objeto tipo;
        public Sprite icono;
        public GameObject prefab;

        [Header("Cantidad")]
        public bool puedeCantidad;
        public int cantidadMaxima;

        [Header("Consumible")]
        public Consumible[] consumibles;

        [Header("Camara")]
        public GameObject objetoEquipado;
    }

    [System.Serializable]
    public class Consumible
    {
        public Tipos.Consumible tipo;
        public float valor;
    }
}