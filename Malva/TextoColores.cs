using UnityEngine;
using TMPro;

public class TextoColores : MonoBehaviour
{
    public TextMeshProUGUI[] textos;
    public float velocidadCambio = 0.5f;

    public Color[] colores = new Color[5]
    {
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow,
        Color.magenta
    };

    private int indiceColor = 0;
    private float tiempo = 0f;

    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= velocidadCambio)
        {
            tiempo = 0f;
            indiceColor = (indiceColor + 1) % colores.Length;

            foreach (var txt in textos)
            {
                txt.faceColor = colores[indiceColor];

            }
        }
        

    }
}
