using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirDialogo : MonoBehaviour
{
    public GameObject PanelDialogo; 

    private bool abierto = false;

    public void CerrarInventario()
    {
        PanelDialogo.SetActive(false);
        Time.timeScale = 1f;
        abierto = false;
    }
}
