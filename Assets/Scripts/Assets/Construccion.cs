using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Construccion", menuName = "Assets/Nueva Construccion")]
    public class Construccion : ScriptableObject
    {
        public string id;

        [Header("Datos")]
        public string nombre;
        public Sprite icono;
        public GameObject prefab;
        public GameObject vistaPreviaPrefab;
        public RecursoCoste[] costes;
    }
}