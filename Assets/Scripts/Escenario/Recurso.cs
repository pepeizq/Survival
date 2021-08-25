using UnityEngine;

namespace Escenario
{
    public class Recurso : MonoBehaviour
    {
        public Assets.Objeto objetoADar;
        public int cantidadPorGolpe = 1;
        public int cantidad;
        public Vector3 posicionCasilla;
        public GameObject particulaGolpe;

        public void Recolectar(Vector3 puntoGolpeo, Vector3 puntoNormal)
        {
            int i = 0;
            while (i < cantidadPorGolpe)
            {
                if (cantidad <= 0)
                {
                    break;
                }

                cantidad -= 1;

                Jugador.Inventario.instancia.AñadirObjeto(objetoADar);
                i += 1;
            }

            Destroy(Instantiate(particulaGolpe, puntoGolpeo, Quaternion.LookRotation(puntoNormal, Vector3.up)), 1f);

            if (cantidad <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

