using UnityEngine;

public enum ObjetoTipo
{
    Recurso,
    Equipable,
    Consumible
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
    }
}

