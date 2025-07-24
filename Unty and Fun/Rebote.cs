using UnityEngine;

public class Rebote : MonoBehaviour
{
    public AudioClip sonidoRebote;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = sonidoRebote;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Solo reproducir si el objeto que colisiona tiene el tag "Jugador"
        if (collision.gameObject.CompareTag("personaje"))
        {
            audioSource.Play();
        }
    }
}
