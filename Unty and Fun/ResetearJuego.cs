using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetearJuego : MonoBehaviour
{
    public void ResetearTodo()
    {
        PlayerPrefs.DeleteAll();  // 🔥 Borra todos los datos
        PlayerPrefs.Save();

        Debug.Log("🧼 Progreso reseteado");

        // Recargar la escena actual para aplicar cambios
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
