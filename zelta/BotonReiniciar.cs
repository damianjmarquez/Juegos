using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonReiniciar : MonoBehaviour
{
    public void IrAlJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
}