using UnityEngine;

public class Recurso : MonoBehaviour
{
    public Objeto.Datos objetoADar;
    public int cantidadPorGolpe = 1;
    public int cantidadMaxima;
    public GameObject particulaGolpe;

    public void Recolectar(Vector3 puntoGolpeo, Vector3 puntoNormal)
    {
        int i = 0;
        while (i < cantidadPorGolpe)
        {
            cantidadMaxima -= 1;

            if (cantidadMaxima <= 0)
            {
                break;
            }

            Jugador.Inventario.instancia.AñadirObjeto(objetoADar);
            i += 1;
        }

        Instantiate(particulaGolpe, puntoGolpeo, Quaternion.LookRotation(puntoNormal, Vector3.up));

        if (cantidadMaxima <= 0)
        {
            Destroy(gameObject);
        }
    }
}
