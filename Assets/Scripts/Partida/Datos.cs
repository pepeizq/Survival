using UnityEngine;

namespace Partida
{
    [System.Serializable]
    public class Datos 
    {
        public VectorTres jugadorPosicion;
        public VectorTres jugadorRotacion;
        public VectorTres jugadorMirar;

        public float vida;
        public float hambre;
        public float sed;
        public float sueño;

        public float tiempoDia;

        public PartidaEscenario escenario;
        public PartidaCasilla[] casillas;
        public PartidaInventarioHueco[] inventario;
        public PartidaObjeto[] objetos;
        public PartidaConstruccion[] construcciones;
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
    public struct PartidaIsla
    {
        public int id;
        public PartidaCasilla[] casillas;
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
    public struct PartidaObjeto
    {
        public string id;
        public VectorTres posicion;
        public VectorTres rotacion;
        public bool fijo;
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
    public struct PartidaEnemigo
    {
        public string prefabId;
        public VectorTres posicion;
        public VectorTres rotacion;
        public int iaEstado;
        public bool intentaMoverse;
        public VectorTres posicionDestino;
    }

    [System.Serializable]
    public struct PartidaCasilla
    {
        public int idCasilla;
        public int idIsla;
        public VectorTres coordenadas;
        public int rotacion;
        public int x;
        public int z;
        public bool recursoPuesto;
        public PartidaRecurso recurso;
    }

    [System.Serializable]
    public struct PartidaRecurso
    {
        public int id;
        public int cantidad;
        public VectorTres posicion;
        public VectorTres rotacion;
        public bool[] subrecursos;
    }

    [System.Serializable]
    public struct PartidaEscenario
    {
        public float casillasEscala;
        public int tamañoEscenarioX;
        public int tamañoEscenarioZ;
    }
}

