using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Isla", menuName = "Assets/Isla")]
    public class Isla : ScriptableObject
    {
        public int id;

        public Casilla[] casillas;


    }
}