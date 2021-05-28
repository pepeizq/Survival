using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Construccion", menuName = "Nueva Construccion")]
    public class Construccion : ScriptableObject
    {
        public string nombre;
        public Sprite icono;
        public GameObject spawneoPrefab;
        public GameObject vistaPreviaPrefab;
        public RecursoCoste[] costes;
    }
}