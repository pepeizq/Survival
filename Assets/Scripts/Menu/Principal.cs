using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

namespace Menu
{
    public class Principal : MonoBehaviour
    {
        public GameObject canvasMenu;
        public GameObject canvasCarga;
        public Button botonContinuar;
        public TextMeshProUGUI porcentaje;

        public void Awake()
        {
            canvasMenu.SetActive(true);
            canvasCarga.SetActive(false);
        }

        public void Start()
        {
            botonContinuar.interactable = PlayerPrefs.HasKey("Guardar");
        }

        public void ContinuarPartida()
        {
            StartCoroutine(Cargar());
        }

        public void NuevaPartida()
        {
            PlayerPrefs.DeleteKey("Guardar");
            StartCoroutine(Cargar());         
        }

        IEnumerator Cargar()
        {
            canvasMenu.SetActive(false);
            canvasCarga.SetActive(true);

            AsyncOperation cargando = SceneManager.LoadSceneAsync("Juego");
            cargando.allowSceneActivation = false;
          
            while (cargando.isDone == false)
            {
                porcentaje.text = cargando.progress.ToString();

                if (cargando.progress > 0.9f)
                {
                    cargando.allowSceneActivation = true;
                }

                yield return new WaitForEndOfFrame();
            }
        }

        public void SalirJuego()
        {
            Application.Quit();
        }
    }
}

