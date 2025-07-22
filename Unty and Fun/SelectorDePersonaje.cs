// Script: SelectorDePersonaje.cs
// Este script va en un objeto vac�o en la escena del men� principal
// Se mantiene activo al cambiar de escena para instanciar el personaje elegido

using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorDePersonaje : MonoBehaviour
{
    public static SelectorDePersonaje instance;

    public GameObject personajeRana;
    public GameObject personajeEspacial;
    public GameObject personajeMascara;
    public GameObject personajeAra�a;

    private GameObject personajeSeleccionado;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SeleccionarPersonaje(string nombre)
    {
        switch (nombre)
        {
            case "rana": personajeSeleccionado = personajeRana; break;
            case "espacial": personajeSeleccionado = personajeEspacial; break;
            case "mascara": personajeSeleccionado = personajeMascara; break;
            case "ara�a": personajeSeleccionado = personajeAra�a; break;
        }

        //SceneManager.sceneLoaded += InstanciarPersonaje;
        //SceneManager.LoadScene("Escena1");
        SceneManager.LoadScene("Niveles");
    }
    //para poder llamar desde Niveles y que lleve a Escena1
    public void CargarNivel(string nombreEscena)
    {
        SceneManager.sceneLoaded += InstanciarPersonaje;
        SceneManager.LoadScene(nombreEscena);
    }


    void InstanciarPersonaje(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.StartsWith("Escena"))
        {
            GameObject puntoInicio = GameObject.Find("PuntoInicio");

            if (puntoInicio != null)
            {
                Instantiate(personajeSeleccionado, puntoInicio.transform.position, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("No se encontr� el objeto 'PuntoInicio'. Instanciando en (0,0)");
                Instantiate(personajeSeleccionado, Vector3.zero, Quaternion.identity);
            }

            SceneManager.sceneLoaded -= InstanciarPersonaje;
        }
    }

    public void SuscribirseInstanciacion()
    {
        SceneManager.sceneLoaded += InstanciarPersonaje;
    }

}
