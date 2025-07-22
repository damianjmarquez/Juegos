using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 8f;

    private Rigidbody2D rb;
    private Animator animator;
    private AudioSource audioSource;

    private bool estaEnElSuelo = true;
    private bool mirandoDerecha = true;

    private float movimientoInput = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        // Avisamos a los botones que este es el personaje actual
        ControlesUI.Instance?.AsignarPersonaje(this);
    }

    void Update()
    {
        float teclado = Input.GetAxisRaw("Horizontal");

        // Combinar teclado con botón
        float movimiento = (teclado != 0) ? teclado : movimientoInput;

        rb.velocity = new Vector2(movimiento * velocidad, rb.velocity.y);

        // Animaciones
        animator.SetBool("Correr", movimiento != 0);
        animator.SetBool("Quieto", movimiento == 0);

        // Salto por teclado
        if (Input.GetKeyDown(KeyCode.Space) && estaEnElSuelo)
        {
            Saltar();
        }

        if (movimiento > 0 && !mirandoDerecha) Girar();
        else if (movimiento < 0 && mirandoDerecha) Girar();
    }

    void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y > 0.5f)
        {
            estaEnElSuelo = true;
            animator.SetBool("Salto", false);
        }
    }

    // Llamado por botón UI
    public void MoverIzquierda(bool presionado)
    {
        movimientoInput = presionado ? -1f : 0f;
    }

    public void MoverDerecha(bool presionado)
    {
        movimientoInput = presionado ? 1f : 0f;
    }

    public void Saltar()
    {
        if (estaEnElSuelo)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            animator.SetBool("Salto", true);
            estaEnElSuelo = false;

            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }
        }
    }
}
