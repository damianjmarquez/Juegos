using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaEscena1 : MonoBehaviour
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
