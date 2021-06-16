using UnityEngine;

namespace CargarGuardar
{
    [System.Serializable]
    public class Partida 
    {
        public VectorTres jugadorPosicion;
        public VectorTres jugadorRotacion;
        public VectorTres jugadorMirar;

        public float vida;
        public float hambre;
        public float sed;
        public float sueño;

        public float tiempoDia;

        public PartidaInventarioHueco[] inventario;
        public PartidaObjetoSuelto[] objetosSueltos;
        public PartidaConstruccion[] construcciones;
        public PartidaRecurso[] recursos;
        public PartidaEnemigo[] enemigos;
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
    public struct PartidaInventarioHueco
    {
        public bool ocupado;
        public string objetoId;
        public int cantidad;
        public bool equipado;
    }

    [System.Serializable]
    public struct PartidaObjetoSuelto
    {
        public string id;
        public VectorTres posicion;
        public VectorTres rotacion;
    }

    [System.Serializable]
    public struct PartidaConstruccion
    {
        public string id;
        public VectorTres posicion;
        public VectorTres rotacion;
        public string propiedades;
    }

    [System.Serializable]
    public struct PartidaRecurso
    {
        public int index;
        public bool destruido;
        public int capacidad;
    }

    [System.Serializable]
    public struct PartidaEnemigo
    {
        public string prefabId;
        public VectorTres posicion;
        public VectorTres rotacion;
        public int iaEstado;
        public bool intentaMoverse;
        public VectorTres posicionDestino;
    }
}

