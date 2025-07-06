using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{
    public Transform objetivo; // El personaje a seguir
    public Vector3 offset;     // Distancia entre la cámara y el personaje

    void LateUpdate()
    {
        if (objetivo != null)
        {
            transform.position = new Vector3(objetivo.position.x + offset.x, objetivo.position.y + offset.y, offset.z);
        }
    }
}
