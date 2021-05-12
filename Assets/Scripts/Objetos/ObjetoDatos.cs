using UnityEngine;

public enum ObjetoTipo
{
    Recurso,
    Equipable,
    Consumible
}

[CreateAssetMenu(fileName = "Objeto", menuName = "Nuevo Objeto")]
public class ObjetoDatos : ScriptableObject
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
