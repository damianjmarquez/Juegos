using UnityEngine;

public class AbrirInventario : MonoBehaviour
{
    public GameObject panelInventario; // Asignalo en el inspector

    private bool abierto = false;

    public void ToggleInventario()
    {
        abierto = !abierto;
        panelInventario.SetActive(abierto);

        if (abierto)
        {
            Time.timeScale = 0f; // Pausa el juego
        }
        else
        {
            Time.timeScale = 1f; // Reanuda el juego
        }
    }

    public void CerrarInventario()
    {
        panelInventario.SetActive(false);
        Time.timeScale = 1f;
        abierto = false;
    }
}
