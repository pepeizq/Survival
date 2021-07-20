using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Isla", menuName = "Assets/Isla")]
    public class Isla : ScriptableObject
    {
        public int id;

        public Casilla[] casillas;

        public float alturaMaxima = 10;
        public Vector2 extensionMaxima = new Vector2(100, 100);
        public Vector2 coordenadasMinimas = new Vector2(0, 0);
    }
}