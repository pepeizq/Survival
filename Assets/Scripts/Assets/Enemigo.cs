using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Enemigo", menuName = "Assets/Enemigo")]
    public class Enemigo : ScriptableObject
    {
        public string id;
        public GameObject prefab;
    }
}

