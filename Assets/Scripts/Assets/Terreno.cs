using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Casilla de Terreno", menuName = "Nueva Casilla de Terreno")]
    public class Terreno : ScriptableObject
    {
        public int id;
        public int idDebug;

        public GameObject modelo;

        public bool edificable;
        public bool recurso;

        [HideInInspector]
        public Vector3 posicion;

        [HideInInspector]
        public int rotacion;

        public Terreno(int ID, int Rotacion, Vector3 Posicion)
        {
            id = ID;
            rotacion = Rotacion;
            posicion = Posicion;
        }
    }
}

