using UnityEngine;

namespace Jugador
{
    public class Equipar : MonoBehaviour
    {
        public Objeto.Camara actualObjetoEquipado;
        public Transform objetoEquipado;

        public static Equipar instancia;

        public void Awake()
        {
            instancia = this;
        }


    }
}