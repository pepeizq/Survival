using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Casilla", menuName = "Assets/Casilla")]
    public class Casilla : ScriptableObject
    {
        public int id;
        public int idDebug;

        public GameObject prefab;

        [HideInInspector]
        public Vector3 posicion;

        [HideInInspector]
        public int rotacion;

        public Casilla(int ID, int Rotacion, Vector3 Posicion)
        {
            id = ID;
            rotacion = Rotacion;
            posicion = Posicion;
        }
    }
}