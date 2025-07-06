using UnityEngine;

public class EnemigoSubeBaja : MonoBehaviour
{
    public float velocidad = 2f;           // Velocidad de movimiento
    public float alturaMovimiento = 3f;    // Qu� tanto sube o baja
    private Vector3 posicionInicial;       // Guarda la posici�n inicial
    private bool bajando = true;           // Direcci�n actual

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Direcci�n: hacia abajo si "bajando" es true, sino hacia arriba
        float direccion = bajando ? -1f : 1f;

        // Movimiento frame a frame
        transform.Translate(Vector2.up * direccion * velocidad * Time.deltaTime);

        // Si baj� mucho, cambia direcci�n
        if (transform.position.y <= posicionInicial.y - alturaMovimiento)
        {
            bajando = false;
        }
        // Si subi� mucho, cambia direcci�n
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
