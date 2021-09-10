using UnityEngine;

namespace CargarGuardar
{
    public class Gestor : MonoBehaviour
    {
        [HideInInspector]
        public Assets.Casilla[] casillas;
        [HideInInspector]
        public Assets.Objeto[] objetos;
        [HideInInspector]
        public Escenario.Recurso[] recursos;
        [HideInInspector]
        public Assets.Construccion[] construcciones;
        [HideInInspector]
        public Assets.Enemigo[] enemigos;

        public static Gestor instancia;

        public void Awake()
        {
            instancia = this;

            casillas = Resources.LoadAll<Assets.Casilla>("Casillas");
            objetos = Resources.LoadAll<Assets.Objeto>("Objetos");
            construcciones = Resources.LoadAll<Assets.Construccion>("Construcciones");
            enemigos = Resources.LoadAll<Assets.Enemigo>("Enemigos");
        }

        public void Start()
        {
            recursos = FindObjectsOfType<Escenario.Recurso>();
        }

        public Assets.Objeto ObtenerObjeto(string id)
        {
            foreach (Assets.Objeto objeto in objetos)
            {
                if (objeto.id == id)
                {
                    return objeto;
                }
            }

            return null;
        }

        public Assets.Construccion ObtenerConstruccion(string id)
        {
            foreach (Assets.Construccion construccion in construcciones)
            {
                if (construccion.id == id)
                {
                    return construccion;
                }
            }

            return null;
        }

        public Assets.Enemigo ObtenerEnemigo(string id)
        {
            foreach (Assets.Enemigo enemigo in enemigos)
            {
                if (enemigo.id == id)
                {
                    return enemigo;
                }
            }

            return null;
        }
    }
}

