using UnityEngine;

public class EnemigoSubeBaja : MonoBehaviour
{
    public float velocidad = 2f;           // Velocidad de movimiento
    public float alturaMovimiento = 3f;    // Qué tanto sube o baja
    private Vector3 posicionInicial;       // Guarda la posición inicial
    private bool bajando = true;           // Dirección actual

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Dirección: hacia abajo si "bajando" es true, sino hacia arriba
        float direccion = bajando ? -1f : 1f;

        // Movimiento frame a frame
        transform.Translate(Vector2.up * direccion * velocidad * Time.deltaTime);

        // Si bajó mucho, cambia dirección
        if (transform.position.y <= posicionInicial.y - alturaMovimiento)
        {
            bajando = false;
        }
        // Si subió mucho, cambia dirección
        else if (transform.position.y >= posicionInicial.y)
        {
            bajando = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("personaje"))
        {
            ControladorVidas.instance.PerderVida();
        }
    }
}
