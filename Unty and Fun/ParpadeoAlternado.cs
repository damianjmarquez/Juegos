using UnityEngine;

public class ParpadeoAlternado : MonoBehaviour
{
    [Header("Configuración de tiempos")]
    [Tooltip("Cuántos segundos estará invisible el objeto")]
    [SerializeField] private float tiempoInvisible = 2f;

    [Tooltip("Cuántos segundos estará visible el objeto")]
    [SerializeField] private float tiempoVisible = 3f;

    private Renderer miRenderer;

    void Start()
    {
        miRenderer = GetComponent<Renderer>();
        StartCoroutine(CicloParpadeo());
    }

    private System.Collections.IEnumerator CicloParpadeo()
    {
        while (true)
        {
            // 🔴 Ocultar
            miRenderer.enabled = false;
            yield return new WaitForSeconds(tiempoInvisible);

            // 🟢 Mostrar
            miRenderer.enabled = true;
            yield return new WaitForSeconds(tiempoVisible);
        }
    }
}
