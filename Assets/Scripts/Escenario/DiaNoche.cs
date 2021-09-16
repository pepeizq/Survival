using UnityEngine;

namespace Escenario
{
    public class DiaNoche : MonoBehaviour
    {
        [Header("Datos")]
        [HideInInspector] [Range(0f, 1f)] public float tiempo;
        public float diaTotalSegundos;
        public float inicioTiempo = 0.45f;
        public Vector3 mediodia;
        [HideInInspector] public int dias;

        private float tiempoIncremento;

        [Header("Dia")]
        public Light solLuz;
        public Gradient solColor;
        public AnimationCurve solIntensidad;

        [Header("Noche")]
        public Light lunaLuz;
        public Gradient lunaColor;
        public AnimationCurve lunaIntensidad;

        [Header("Skybox")]
        public Gradient cieloSkyboxColor;
        public Gradient sueloSkyboxColor;
        private float atmosfera;
        private float exposicion;

        [Header("Luces Adicionales")]
        public AnimationCurve luzIntesidadMultiplicador;
        public AnimationCurve reflejosIntesidadMultiplicador;

        public static DiaNoche instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Start()
        {
            tiempoIncremento = 1.0f / diaTotalSegundos;
            tiempo = inicioTiempo;

            atmosfera = tiempo;
            exposicion = 1.5f;
            dias = 1;
        }

        public void Update()
        {
            //incremento
            tiempo += tiempoIncremento * Time.deltaTime;

            if (tiempo >= 1f)
            {
                tiempo = 0f;
                dias += 1;

                Generar.Recursos.instancia.Comprobar();
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

            //skybox
            if (tiempo > 0.5f)
            {
                atmosfera -= 2 * tiempoIncremento * Time.deltaTime;
                exposicion -= tiempoIncremento * Time.deltaTime;
            }
            else
            {
                atmosfera += 2 * tiempoIncremento * Time.deltaTime;
                exposicion += tiempoIncremento * Time.deltaTime;
            }

            RenderSettings.skybox.SetFloat("_AtmosphereThickness", atmosfera);
            RenderSettings.skybox.SetFloat("_Exposure", exposicion);
            RenderSettings.skybox.SetColor("_SkyTint", cieloSkyboxColor.Evaluate(tiempo));
            RenderSettings.skybox.SetColor("_GroundColor", sueloSkyboxColor.Evaluate(tiempo));

            //otras luces y reflejos
            RenderSettings.ambientIntensity = luzIntesidadMultiplicador.Evaluate(tiempo);
            RenderSettings.reflectionIntensity = reflejosIntesidadMultiplicador.Evaluate(tiempo);
        }
    }
}