using UnityEngine;

namespace Guardar
{
    public class Manager : MonoBehaviour
    {
        public Assets.Objeto[] objetos;
        public Recurso[] recursos;
        public Assets.Construccion[] construcciones;
        public Assets.Enemigo[] enemigos;

        public static Manager instancia;

        public void Awake()
        {
            instancia = this;

            objetos = Resources.LoadAll<Assets.Objeto>("Objetos");
            construcciones = Resources.LoadAll<Assets.Construccion>("Construcciones");
            enemigos = Resources.LoadAll<Assets.Enemigo>("Enemigos");
        }

        public void Start()
        {
            
        }
    }
}

