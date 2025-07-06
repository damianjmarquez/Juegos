using UnityEngine;

public class MusicaFondo : MonoBehaviour
{
    private static MusicaFondo instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // No destruir entre escenas
        }
        else
        {
            Destroy(gameObject); // Si ya existe, eliminar duplicado
        }
    }
}
