using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class Principal : MonoBehaviour
    {
        public Button botonContinuar;

        public void Start()
        {
            botonContinuar.interactable = PlayerPrefs.HasKey("Guardar");
        }

        public void ContinuarPartida()
        {
            SceneManager.LoadScene("Juego");
        }

        public void NuevaPartida()
        {
            PlayerPrefs.DeleteKey("Guardar");
            SceneManager.LoadScene("Juego");
        }

        public void SalirJuego()
        {
            Application.Quit();
        }
    }
}

