using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Casilla", menuName = "Assets/Casilla")]
    public class Casilla : ScriptableObject
    {
        public int id;
        public int idDebug;

        public GameObject prefab;

        [Header("Recurso")]
        public bool recursoPosible;
        public Vector3 recursoPosicion;

        [HideInInspector]
        public Vector3 posicion;

        [HideInInspector]
        public int rotacion;

        [HideInInspector]
        public Isla isla;

        [HideInInspector]
        public bool contruido;

        public Casilla(int ID, int Rotacion, Vector3 Posicion)
        {
            id = ID;
            rotacion = Rotacion;
            posicion = Posicion;
        }
    }
}