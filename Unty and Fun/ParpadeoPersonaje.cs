using System.Collections;
using UnityEngine;

public class ParpadeoPersonaje : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool invulnerable = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void RecibirDaño()
    {
        if (invulnerable) return;

        ControladorVidas.instance.PerderVida();
        StartCoroutine(Parpadear());
    }

    IEnumerator Parpadear()
    {
        invulnerable = true;

        for (int i = 0; i < 5; i++)
        {
            spriteRenderer.enabled = false;
            yield return new WaitForSeconds(0.1f);
            spriteRenderer.enabled = true;
            yield return new WaitForSeconds(0.1f);
        }

        invulnerable = false;
    }
}
