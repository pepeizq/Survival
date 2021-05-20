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
            if (cantidadMaxima <= 0)
            {
                break;
            }

            cantidadMaxima -= 1;

            Jugador.Inventario.instancia.AñadirObjeto(objetoADar);
            i += 1;
        }

        Destroy(Instantiate(particulaGolpe, puntoGolpeo, Quaternion.LookRotation(puntoNormal, Vector3.up)), 1f);

        if (cantidadMaxima <= 0)
        {
            Destroy(gameObject);
        }
    }
}
