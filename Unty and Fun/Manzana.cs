using UnityEngine;

public class Manzana : MonoBehaviour
{
    private AudioSource audioSource;
    private bool recogida = false;
    public GameObject efectoPolvoPrefab;  // ← Arrastrá el prefab desde el Inspector

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!recogida && other.CompareTag("personaje"))
        {
            recogida = true;

            if (audioSource != null && audioSource.clip != null)
                audioSource.Play();

            GameManager.instance.SumarManzana();

            // 🔁 Si hay una UI activa, actualizala
            ContadorItems ui = FindObjectOfType<ContadorItems>();
            if (ui != null)
                ui.ActualizarTexto();


            // Desactivar parte visual y colisión
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            // 🎆 Instanciar estallido visual
            if (efectoPolvoPrefab != null)
                Instantiate(efectoPolvoPrefab, transform.position, Quaternion.identity);

            // Destruir después del sonido
            Destroy(gameObject, audioSource.clip.length);
        }
    }
}
