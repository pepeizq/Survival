using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Jugador
{
    public class Necesidades : MonoBehaviour, iDañable
    {
        public Necesidad vida;
        public Necesidad hambre;
        public Necesidad sediento;
        public Necesidad sueño;

        public float hambreDecaerVida;
        public float sedientoDecaerVida;

        public UnityEvent recibirDañoEvento;

        public static Necesidades instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Start()
        {
            vida.valorActual = vida.valorInicio;
            hambre.valorActual = hambre.valorInicio;
            sediento.valorActual = sediento.valorInicio;
            sueño.valorActual = sueño.valorInicio;
        }

        public void Update()
        {
            hambre.Quitar(hambre.decaer * Time.deltaTime);
            sediento.Quitar(sediento.decaer * Time.deltaTime);
            sueño.Añadir(sueño.regenerar * Time.deltaTime);

            if (hambre.valorActual == 0.0f)
            {
                vida.Quitar(hambreDecaerVida * Time.deltaTime);
            }

            if (sediento.valorActual == 0.0f)
            {
                vida.Quitar(sedientoDecaerVida * Time.deltaTime);
            }

            if (vida.valorActual == 0.0f)
            {
                Muerte();
            }

            vida.barra.fillAmount = vida.Porcentaje();
            hambre.barra.fillAmount = hambre.Porcentaje();
            sediento.barra.fillAmount = sediento.Porcentaje();
            sueño.barra.fillAmount = sueño.Porcentaje();
        }

        public void Curar(float cantidad)
        {
            vida.Añadir(cantidad);
        }

        public void Comer(float cantidad)
        {
            hambre.Añadir(cantidad);
        }

        public void Beber(float cantidad)
        {
            sediento.Añadir(cantidad);
        }

        public void Dormir(float cantidad)
        {
            sueño.Quitar(cantidad);
        }

        public void RecibirDaño(int cantidad)
        {
            vida.Quitar(cantidad);
            recibirDañoEvento?.Invoke();
        }

        public void Muerte()
        {
            Debug.Log("Jugador Muerto");
        }
    }
}

[System.Serializable]
public class Necesidad
{
    [HideInInspector]
    public float valorActual;

    public float valorMaximo;
    public float valorInicio;
    public float regenerar;
    public float decaer;
    public Image barra;

    public void Añadir(float cantidad)
    {
        valorActual = Mathf.Min(valorActual + cantidad, valorMaximo);
    }

    public void Quitar(float cantidad)
    {
        valorActual = Mathf.Max(valorActual - cantidad, 0.0f);
    }

    public float Porcentaje()
    {
        return valorActual / valorMaximo;
    }
}

public interface iDañable
{
    void RecibirDaño(int cantidad);
}