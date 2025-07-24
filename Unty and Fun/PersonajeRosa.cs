using UnityEngine;

public class PersonajeRosa : MonoBehaviour
{
    public float velocidad = 6f;
    public float distancia = 8.2f;
    public GameObject rayitoPrefab;
    public Transform puntoDisparo;
    public float tiempoEntreDisparos = 2f;
    public float velocidadRayito = 5f;

    private Vector3 posicionInicial;
    private bool haciaDerecha = true;
    private float temporizadorDisparo;

    void Start()
    {
        posicionInicial = transform.position;
        temporizadorDisparo = tiempoEntreDisparos;
    }

    void Update()
    {
        // Movimiento
        if (haciaDerecha)
        {
            transform.Translate(Vector2.right * velocidad * Time.deltaTime);
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

            if (transform.position.x >= posicionInicial.x + distancia)
                haciaDerecha = false;
        }
        else
        {
            transform.Translate(Vector2.left * velocidad * Time.deltaTime);
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

            if (transform.position.x <= posicionInicial.x - distancia)
                haciaDerecha = true;
        }

        // Disparo
        temporizadorDisparo -= Time.deltaTime;
        if (temporizadorDisparo <= 0f)
        {
            Disparar();
            temporizadorDisparo = tiempoEntreDisparos;
        }
    }

    void Disparar()
    {
        if (rayitoPrefab != null && puntoDisparo != null)
        {
            GameObject rayito = Instantiate(rayitoPrefab, puntoDisparo.position, Quaternion.identity);
            Rigidbody2D rb = rayito.GetComponent<Rigidbody2D>();

            // Dirección del disparo: +1 si derecha, -1 si izquierda
            float direccion = haciaDerecha ? 1f : -1f;
            rb.velocity = new Vector2(direccion * velocidadRayito, 0f);

            Destroy(rayito, 1f);
        }
    }

    
}
