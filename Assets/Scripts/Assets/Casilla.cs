using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Casilla", menuName = "Assets/Casilla")]
    public class Casilla : ScriptableObject
    {
        public int id;
        public int idDebug;
        [HideInInspector] public int idColocacion;

        public GameObject prefab;

        [Header("Recurso")]
        public bool recursoPosible;
        public Vector3 recursoPosicion;
        [HideInInspector] public GameObject recurso;
        [HideInInspector] public int recursoID;
        [HideInInspector] public bool recursoPuesto;

        [Header("Construcciones")]
        public bool construccionPosible;
        [HideInInspector] public List<Piso> pisos;
        public List<Vector3> posicionesSuelo;
        public List<Vector3> posicionesParedes;

        [HideInInspector] public Vector3 posicion;
        [HideInInspector] public int rotacion;
        [HideInInspector] public Isla isla;

        public Casilla(int ID, int Rotacion, Vector3 Posicion)
        {
            id = ID;
            rotacion = Rotacion;
            posicion = Posicion;
        }
    }

    public class Piso : MonoBehaviour
    {
        public GameObject suelo;
        public GameObject pared;
    }
}