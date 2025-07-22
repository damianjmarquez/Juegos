using UnityEngine;

public class MusicaMenu : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.loop = true;  // Para que la música no se corte
            audioSource.Play();
        }
    }
}
