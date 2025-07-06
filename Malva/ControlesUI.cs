using UnityEngine;

public class ControlesUI : MonoBehaviour
{
    public MovimientoPersonaje personaje;

    private int direccion = 0;
    private bool presionarSalto = false;

    public void BotonIzquierdaPresionado() { direccion = -1; }
    public void BotonDerechaPresionado() { direccion = 1; }
    public void BotonSoltado() { direccion = 0; }
    public void BotonSaltoPresionado() { presionarSalto = true; }

    void Update()
    {
        personaje.Mover(direccion);

        if (presionarSalto)
        {
            personaje.Saltar();
            presionarSalto = false;
        }
    }
}
