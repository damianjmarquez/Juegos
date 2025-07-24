using UnityEngine;

public class InteraccionNPC : MonoBehaviour
{
    public GameObject panelInteraccion;
    public DialogoManager dialogoManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("nps"))
        {
            panelInteraccion.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("nps"))
        {
            panelInteraccion.SetActive(false);

            if (dialogoManager != null)
            {
                dialogoManager.ReiniciarDialogo(); // ← esto reinicia todo
            }

            
        }
    }

}
