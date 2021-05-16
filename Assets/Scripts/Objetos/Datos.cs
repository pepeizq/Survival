using UnityEngine;

public enum ObjetoTipo
{
    Recurso,
    Equipable,
    Consumible
}

public enum ConsumibleTipo
{
    Hambre,
    Sed,
    Salud,
    Sueño
}

namespace Objeto
{
    [CreateAssetMenu(fileName = "Objeto", menuName = "Nuevo Objeto")]
    public class Datos : ScriptableObject
    {
        [Header("Datos")]
        public string nombre;
        public string descripcion;
        public ObjetoTipo tipo;
        public Sprite icono;
        public GameObject prefab;

        [Header("Cantidad")]
        public bool puedeCantidad;
        public int cantidadMaxima;

        [Header("Consumible")]
        public Consumible[] consumibles;
    }

    [System.Serializable]
    public class Consumible
    {
        public ConsumibleTipo tipo;
        public float valor;
    }
}