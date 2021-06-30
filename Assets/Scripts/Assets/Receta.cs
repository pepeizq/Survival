using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Receta de Crafting", menuName = "Assets/Nueva Receta de Crafting")]
    public class Receta : ScriptableObject
    {
        public Objeto objetoACraftear;
        public RecursoCoste[] costes;
    }

    [System.Serializable]
    public class RecursoCoste
    {
        public Objeto objeto;
        public int cantidad;
    }
}