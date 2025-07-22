using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorVidas : MonoBehaviour
{
    public static ControladorVidas instance;

    public Image vida1;
    public Image vida2;
    public Image vida3;
    public Image vida4;

    private int vidas = 4;

    void Awake()
    {
        instance = this;

        if (vida1 == null || vida2 == null || vida3 == null || vida4 == null)
        {
            Debug.LogError("Una de las imágenes de vida no está asignada correctamente.");
        }
    }

    public void PerderVida()
    {
        vidas--;

        if (vidas == 3)
        {
            vida4.enabled = false;
        }
        else if (vidas == 2)
        {
            vida3.enabled = false;
        }
        else if (vidas == 1)
        {
            vida2.enabled = false;
        }
        else if (vidas == 0)
        {
            vida1.enabled = false;

            // Reiniciar escena después de 0.3 segundos
            Invoke("ReiniciarNivel", 0.3f);
        }
    }

    void ReiniciarNivel()
    {
        Scene escenaActual = SceneManager.GetActiveScene();
        SelectorDePersonaje.instance?.SuscribirseInstanciacion();
        SceneManager.LoadScene(escenaActual.name);
    }
}
