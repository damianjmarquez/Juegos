using UnityEngine;
using UnityEngine.UI;

public class DesbloquearNiveles : MonoBehaviour
{
    public Button botonNivel2;
    public GameObject panelBloqueoNivel2; // imagen oscura o candado

    public Button botonNivel3;
    public GameObject panelBloqueoNivel3;

    public Button botonNivel4;
    public GameObject panelBloqueoNivel4;

    public Button botonNivel5;
    public GameObject panelBloqueoNivel5;

    public Button botonNivel6;
    public GameObject panelBloqueoNivel6;



    void Start()
    {
        int manzanas = PlayerPrefs.GetInt("Manzanas", 0);
        int bananas = PlayerPrefs.GetInt("Bananas", 0);
        int sandias = PlayerPrefs.GetInt("Sandias", 0);
        int kiwis = PlayerPrefs.GetInt("Kiwis", 0);
        int naranjas = PlayerPrefs.GetInt("Naranjas", 0);
        Debug.Log("🔍 Manzanas guardadas en PlayerPrefs: " + manzanas);
        Debug.Log("🍌 Bananas guardadas en PlayerPrefs: " + bananas);
        Debug.Log(" Sandias guardadas en PlayerPrefs: " + sandias);
        Debug.Log(" kiwis guardadas en PlayerPrefs: " + kiwis);
        Debug.Log(" Naranjas guardadas en PlayerPrefs: " + naranjas);

        if (manzanas >= 25)
        {
            botonNivel2.interactable = true;
            if (panelBloqueoNivel2 != null)
                panelBloqueoNivel2.SetActive(false);
        }
        else
        {
            botonNivel2.interactable = false;
            if (panelBloqueoNivel2 != null)
                panelBloqueoNivel2.SetActive(true);
        }

        if (bananas >= 30)
        {
            botonNivel3.interactable = true;
            if (panelBloqueoNivel3 != null)
                panelBloqueoNivel3.SetActive(false);
        }
        else
        {
            botonNivel3.interactable = false;
            if (panelBloqueoNivel3 != null)
                panelBloqueoNivel3.SetActive(true);
        }

        if (sandias >= 35)
        {
            botonNivel4.interactable = true;
            if (panelBloqueoNivel4 != null)
                panelBloqueoNivel4.SetActive(false);
        }
        else
        {
            botonNivel4.interactable = false;
            if (panelBloqueoNivel4 != null)
                panelBloqueoNivel4.SetActive(true);
        }

        if (kiwis >= 40)
        {
            botonNivel5.interactable = true;
            if (panelBloqueoNivel5 != null)
                panelBloqueoNivel5.SetActive(false);
        }
        else
        {
            botonNivel5.interactable = false;
            if (panelBloqueoNivel5 != null)
                panelBloqueoNivel5.SetActive(true);
        }

        if (naranjas >= 45)
        {
            botonNivel6.interactable = true;
            if (panelBloqueoNivel6 != null)
                panelBloqueoNivel6.SetActive(false);
        }
        else
        {
            botonNivel6.interactable = false;
            if (panelBloqueoNivel6 != null)
                panelBloqueoNivel6.SetActive(true);
        }


    }
}
