using UnityEngine;
using TMPro;

public class ContadorItems : MonoBehaviour
{
    public TextMeshProUGUI textoManzanas;
    public TextMeshProUGUI textoBananas;
    public TextMeshProUGUI textoSandias;
    public TextMeshProUGUI textoCerezas;
    public TextMeshProUGUI textoKiwi;
    public TextMeshProUGUI textoAnana;
    public TextMeshProUGUI textoFrutilla;
    public TextMeshProUGUI textoNaranja;

    void Start()
    {
        ActualizarTexto();
    }

    public void ActualizarTexto()
    {
        textoManzanas.text = GameManager.instance.manzanas.ToString();
        textoBananas.text = GameManager.instance.bananas.ToString();
        textoSandias.text = GameManager.instance.sandias.ToString();
        textoCerezas.text = GameManager.instance.cerezas.ToString();
        textoKiwi.text = GameManager.instance.kiwis.ToString();
        textoAnana.text = GameManager.instance.anana.ToString();
        textoFrutilla.text = GameManager.instance.frutilla.ToString();
        textoNaranja.text = GameManager.instance.naranjas.ToString();
    }
}
