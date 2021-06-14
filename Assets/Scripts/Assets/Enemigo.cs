using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Enemigo", menuName = "Nuevo Enemigo")]
    public class Enemigo : ScriptableObject
    {
        public string id;
        public GameObject prefab;
    }
}

