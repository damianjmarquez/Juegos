using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogoNPC : MonoBehaviour
{
    public GameObject panelNps;            // Todo el panel que se activa al acercarse
    public TMP_Text textoDialogo;          // Texto que cambia con el bot�n
    public Button botonSiguiente;          // Bot�n para cambiar de l�nea

    [TextArea(3, 10)]
    public string[] lineasDialogo;

    private int indiceLinea = 0;

    private void Start()
    {
        if (botonSiguiente != null)
        {
            botonSiguiente.onClick.RemoveAllListeners(); // evita duplicados
            botonSiguiente.onClick.AddListener(SiguienteLinea);
        }

        panelNps.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("personaje"))
        {
            indiceLinea = 0;
            textoDialogo.text = lineasDialogo[indiceLinea];
            panelNps.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("personaje"))
        {
            panelNps.SetActive(false);
            indiceLinea = 0;
        }
    }

    public void SiguienteLinea()
    {
        indiceLinea++;

        if (indiceLinea < lineasDialogo.Length)
        {
            textoDialogo.text = lineasDialogo[indiceLinea];
        }
        else
        {
            // Si ya no hay m�s l�neas, pod�s dejar el �ltimo mensaje
            // o cerrar el panel si prefer�s:
            // panelNps.SetActive(false);
        }
    }
}
