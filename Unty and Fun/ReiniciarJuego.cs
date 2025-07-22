using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarJuego : MonoBehaviour
{
    public void Reiniciar()
    {
        PlayerPrefs.DeleteAll();  // 🔥 Borra todos los datos guardados
        PlayerPrefs.Save();       // 💾 Asegura que se guarden los cambios

        SceneManager.LoadScene("Presentacion"); // 🔄 Reinicia la escena
    }
}
