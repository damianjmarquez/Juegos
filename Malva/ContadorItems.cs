
using UnityEngine;
using TMPro;

public class ContadorItems : MonoBehaviour
{
    public static ContadorItems instance;

    public int monedas = 0;
    public int manzanas = 0;
    public int bananas = 0;

    public TextMeshProUGUI textoMonedas;
    public TextMeshProUGUI textoManzanas;
    public TextMeshProUGUI textoBananas;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject); // Evita duplicados
    }

    public void SumarMoneda()
    {
        monedas++;
        textoMonedas.text = monedas.ToString();
    }

    public void SumarManzana()
    {
        manzanas++;
        textoManzanas.text = manzanas.ToString();
    }
    public void SumarBanana()
    {
        bananas++;
        textoBananas.text = bananas.ToString();
    }
}
