using UnityEngine;

public class MovCam : MonoBehaviour
{
    public Transform objetivo;     // Se llenará automáticamente
    public float suavizado = 0.1f;
    public float minY = 0f;
    public float maxY = 10f;

    private Vector3 velocidad = Vector3.zero;
    private float posicionFijaX;

    void Start()
    {
        posicionFijaX = transform.position.x;
    }

    void LateUpdate()
    {
        // Si aún no hay objetivo, intentamos encontrarlo
        if (objetivo == null)
        {
            GameObject obj = GameObject.FindWithTag("personaje");
            if (obj != null)
            {
                objetivo = obj.transform;
            }
            return; // Hasta que no lo encuentre, no continúa
        }

        // Seguimiento en eje Y solamente
        float yLimitado = Mathf.Clamp(objetivo.position.y, minY, maxY);
        Vector3 posicionDeseada = new Vector3(posicionFijaX, yLimitado, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, posicionDeseada, ref velocidad, suavizado);
    }
}
