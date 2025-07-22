using UnityEngine;
using UnityEngine.SceneManagement;

public class CamEsc2 : MonoBehaviour
{
    public string nombreEscenaDestino = "Niveles"; // <- la escena para volver
    private bool yaCambiandoEscena = false;

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!yaCambiandoEscena && other.CompareTag("personaje"))
        {
            yaCambiandoEscena = true;

            // 🔽 GUARDAR LA CANTIDAD DE MANZANAS ANTES DE CAMBIAR DE ESCENA
            int totalManzanas = GameManager.instance.manzanas;
            int totalBananas = GameManager.instance.bananas;
            int totalSandias = GameManager.instance.sandias;
            int totalKiwis = GameManager.instance.kiwis;
            int totalNaranjas = GameManager.instance.naranjas;

            PlayerPrefs.SetInt("Manzanas", totalManzanas);
            PlayerPrefs.SetInt("Bananas", totalBananas);
            PlayerPrefs.SetInt("Sandias", totalSandias);
            PlayerPrefs.SetInt("Kiwis", totalKiwis);
            PlayerPrefs.SetInt("Naranjas", totalNaranjas);
            PlayerPrefs.Save();

            // 🔁 Volver a la escena de Niveles
            SceneManager.LoadScene(nombreEscenaDestino);
        }
    }
}
