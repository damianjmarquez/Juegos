using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscenaAlTocar : MonoBehaviour
{
    public string nombreEscenaDestino = "Escena2"; // Cambiá por el nombre real

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("personaje")) // Asegurate que tu personaje tenga este tag
        {
            SceneManager.LoadScene(nombreEscenaDestino);
        }
    }
}
