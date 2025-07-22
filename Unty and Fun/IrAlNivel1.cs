using UnityEngine;

public class BotonNivel : MonoBehaviour
{
    [Header("Nombre de la escena a cargar")]
    public string nombreEscena;

    public void IrAlNivel()
    {
        if (SelectorDePersonaje.instance != null)
        {
            SelectorDePersonaje.instance.CargarNivel(nombreEscena);
        }
        else
        {
            Debug.LogWarning("No se encontró SelectorDePersonaje");
        }
    }
}
