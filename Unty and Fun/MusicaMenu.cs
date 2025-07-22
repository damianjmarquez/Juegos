using UnityEngine;

public class MusicaMenu : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.loop = true;  // Para que la m�sica no se corte
            audioSource.Play();
        }
    }
}
