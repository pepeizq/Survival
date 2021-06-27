using UnityEngine;

namespace Escenario.Generar
{
    public class Casilla : MonoBehaviour
    {
        public int id;
        public int idDebug;

        public bool edificable;
        public bool arbolable;

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