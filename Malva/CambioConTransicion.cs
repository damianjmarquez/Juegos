using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class CambioConTransicion : MonoBehaviour
{
    public Image panelNegro; // Referencia al panel negro 
    public float velocidadTransicion = 1.5f;
    public string nombreEscenaDestino = "Escena2";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("personaje"))
        {
            StartCoroutine(FundidoYCambio());
        }
    }

    IEnumerator FundidoYCambio()
    {
        float alpha = panelNegro.color.a;
        Color color = panelNegro.color;

        while (alpha < 1f)
        {
            alpha += Time.deltaTime * velocidadTransicion;
            panelNegro.color = new Color(color.r, color.g, color.b, alpha);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f); // tiempo de espera para reiniciar

        SceneManager.LoadScene(nombreEscenaDestino);
    }
}
