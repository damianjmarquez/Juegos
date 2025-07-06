
using UnityEngine;

public class Manzana : MonoBehaviour
{
    private AudioSource audioSource;
    private bool recogida = false;

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

            ContadorItems.instance.SumarManzana();

            Destroy(gameObject, audioSource.clip.length);
        }
    }
}
