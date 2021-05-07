using UnityEngine;

public class DiaNoche : MonoBehaviour
{
    [Header("Datos")]
    [HideInInspector] [Range(0f, 1f)]
    public float tiempo;
    public float diaTotalSegundos;
    public float inicioTiempo = 0.45f;
    public Vector3 mediodia;

    private float tiempoIncremento;

    [Header("Sol")]
    public Light solLuz;
    public Gradient solColor;
    public AnimationCurve solIntensidad;

    [Header("Luna")]
    public Light lunaLuz;
    public Gradient lunaColor;
    public AnimationCurve lunaIntensidad;

    [Header("Luces Adicionales")]
    public AnimationCurve luzIntesidadMultiplicador;
    public AnimationCurve reflejosIntesidadMultiplicador;

    public void Start()
    {
        tiempoIncremento = 1.0f / diaTotalSegundos;
        tiempo = inicioTiempo;
    }

    public void Update()
    {
        //incremento
        tiempo += tiempoIncremento * Time.deltaTime;

        if (tiempo >= 1f)
        {
            tiempo = 0f;
        }

        //rotacion
        solLuz.transform.eulerAngles = (tiempo - 0.25f) * mediodia * 4f;
        lunaLuz.transform.eulerAngles = (tiempo - 0.75f) * mediodia * 4f;

        //intensidad
        solLuz.intensity = solIntensidad.Evaluate(tiempo);
        lunaLuz.intensity = lunaIntensidad.Evaluate(tiempo);

        //colores
        solLuz.color = solColor.Evaluate(tiempo);
        lunaLuz.color = lunaColor.Evaluate(tiempo);

        //activar desactivar sol
        if (solLuz.intensity == 0f && solLuz.gameObject.activeInHierarchy == true)
        {
            solLuz.gameObject.SetActive(false);
        }
        else if (solLuz.intensity > 0f && solLuz.gameObject.activeInHierarchy == false)
        {
            solLuz.gameObject.SetActive(true);
        }

        //activar desactivar luna
        if (lunaLuz.intensity == 0f && lunaLuz.gameObject.activeInHierarchy == true)
        {
            lunaLuz.gameObject.SetActive(false);
        }
        else if (lunaLuz.intensity > 0f && lunaLuz.gameObject.activeInHierarchy == false)
        {
            lunaLuz.gameObject.SetActive(true);
        }

        //otras luces y reflejos
        RenderSettings.ambientIntensity = luzIntesidadMultiplicador.Evaluate(tiempo);
        RenderSettings.reflectionIntensity = reflejosIntesidadMultiplicador.Evaluate(tiempo);
    }
}
