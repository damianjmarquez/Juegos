using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{
    public void IrAEscena1()
    {
        SceneManager.LoadScene("Escena1"); // Asegurate que el nombre coincida exactamente
    }
}
