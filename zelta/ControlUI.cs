using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlUI : MonoBehaviour
{
    public Personaje personaje;

    private Vector2 direccion = Vector2.zero;
    private bool presionarGolpear = false;

    public void BotonIzquierdaPresionado() { direccion.x = -1; }
    public void BotonDerechaPresionado() { direccion.x = 1; }
    public void BotonArribaPresionado() { direccion.y = 1; }
    public void BotonAbajoPresionado() { direccion.y = -1; }

    public void BotonIzquierdaSoltado() { if (direccion.x == -1) direccion.x = 0; }
    public void BotonDerechaSoltado() { if (direccion.x == 1) direccion.x = 0; }
    public void BotonArribaSoltado() { if (direccion.y == 1) direccion.y = 0; }
    public void BotonAbajoSoltado() { if (direccion.y == -1) direccion.y = 0; }

    public void BotonGolpearPresionado() { presionarGolpear = true; }

    void Update()
    {
        personaje.Mover(direccion);

        if (presionarGolpear)
        {
            personaje.Golpear();
            presionarGolpear = false;
        }
    }
}
