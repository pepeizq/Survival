using UnityEngine;

namespace Guardar
{
    [System.Serializable]
    public class Guarda 
    {
        public VectorTres jugadorPosicion;
        public VectorTres jugadorRotacion;
        public VectorTres jugadorMirar;

        public float vida;
        public float hambre;
        public float sed;
        public float sueño;

        public float tiempoDia;

        public InventarioHueco[] inventario;
        public ObjetoSuelto[] objetosSueltos;
        public Construccion[] construcciones;
        public Recurso[] recursos;
        public Enemigo[] enemigos;
    }

    [System.Serializable]
    public struct VectorTres
    {
        public float x;
        public float y;
        public float z;

        public VectorTres(Vector3 vector)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
        }

        public Vector3 ObtenerVector3()
        {
            return new Vector3(x, y, z);
        }
    }

    [System.Serializable]
    public struct InventarioHueco
    {
        public bool ocupado;
        public string objetoId;
        public int cantidad;
        public bool equipado;
    }

    [System.Serializable]
    public struct ObjetoSuelto
    {
        public string objetoId;
        public VectorTres posicion;
        public VectorTres rotacion;
    }

    [System.Serializable]
    public struct Construccion
    {
        public string construccionId;
        public VectorTres posicion;
        public VectorTres rotacion;
        public string propiedades;
    }

    [System.Serializable]
    public struct Recurso
    {
        public int index;
        public bool destruido;
        public int capacidad;
    }

    [System.Serializable]
    public struct Enemigo
    {
        public int prefabId;
        public VectorTres posicion;
        public VectorTres rotacion;
        public int iaEstado;
        public bool intentaMoverse;
        public Vector3 posicionDestino;
    }
}

