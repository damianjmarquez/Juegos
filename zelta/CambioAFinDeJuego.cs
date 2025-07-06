using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioAFinDeJuego : MonoBehaviour
{
    void Update()
    {
        GameObject[] monedas = GameObject.FindGameObjectsWithTag("Moneda");

        if (monedas.Length == 0)
        {
            SceneManager.LoadScene("MenuFin"); // Cambia a la escena final
        }
    }
}
