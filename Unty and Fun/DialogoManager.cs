using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogoManager : MonoBehaviour
{
    public GameObject panelNps;
    public TMP_Text textoDialogo;
    public Button botonSiguiente;
    public string textoinicial;
   

    [TextArea(3, 10)]
    public string[] lineasDialogo;

    private int indiceLinea = 0;

    private void Start()
    {
        botonSiguiente.onClick.RemoveAllListeners(); // ← esto evita eventos duplicados
        botonSiguiente.onClick.AddListener(SiguienteLinea);
    }

    public void MostrarDialogo()
    {
        if (panelNps == null)
        {
            Debug.LogError("panelNps no está asignado.");
            return;
        }

        panelNps.SetActive(true);
        indiceLinea = 0;

        // Esto asegura que la primera línea se muestre bien
        if (lineasDialogo.Length > 0)
        {
            textoDialogo.text = lineasDialogo[0];
        }
        else
        {
            textoDialogo.text = "";
        }

        Debug.Log("Mostrando diálogo: " + textoDialogo.text);
    }

    public void ReiniciarDialogo()
    {
             
        indiceLinea = 0;             
        textoDialogo.text = textoinicial;       
    }

    public void SiguienteLinea()
    {
        indiceLinea++;

        if (indiceLinea < lineasDialogo.Length)
        {
            textoDialogo.text = lineasDialogo[indiceLinea];
        }
        
    }
}
