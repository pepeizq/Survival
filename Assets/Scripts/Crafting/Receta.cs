using UnityEngine;

namespace Crafting
{
    [CreateAssetMenu(fileName = "Receta de Crafting", menuName = "Nueva Receta de Crafting")]
    public class Receta : ScriptableObject
    {
        public Objeto.Datos objetoACraftear;
        public RecursoCoste[] costes;
    }

    [System.Serializable]
    public class RecursoCoste
    {
        public Objeto.Datos objeto;
        public int cantidad;
    }
}