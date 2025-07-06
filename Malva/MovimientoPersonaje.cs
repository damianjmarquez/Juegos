using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 8f;
    public int saltosMaximos = 2;

    private Rigidbody2D rb;
    private Animator animator;
    private bool mirandoDerecha = true;
    private int saltosRestantes;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        saltosRestantes = saltosMaximos;
    }

    void Update()
    {
        /*
        float movimiento = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movimiento * velocidad, rb.velocity.y);

        // Animaciones caminar/quieto
        if (movimiento != 0)
        {
            animator.SetBool("correr", true);
            animator.SetBool("quieto", false);
        }
        else
        {
            animator.SetBool("correr", false);
            animator.SetBool("quieto", true);
        }

        // Girar personaje
        if (movimiento > 0 && !mirandoDerecha)
            Girar();
        else if (movimiento < 0 && mirandoDerecha)
            Girar();
        */
        // Saltar (doble salto)
        if (Input.GetKeyDown(KeyCode.Space) && saltosRestantes > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            animator.SetBool("saltar", true);
            saltosRestantes--;
        }

        // Animación dejar de saltar (cuando cae)
        if (rb.velocity.y <= 0)
        {
            animator.SetBool("saltar", false);
        }
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
        // Si toca el suelo, reinicia los saltos
        if (collision.contacts[0].normal.y > 0.5f)
        {
            saltosRestantes = saltosMaximos;
        }
    }
    public void Mover(int direccion)
    {
        rb.velocity = new Vector2(direccion * velocidad, rb.velocity.y);

        if (direccion != 0)
        {
            animator.SetBool("correr", true);
            animator.SetBool("quieto", false);
            if (direccion > 0 && !mirandoDerecha) Girar();
            else if (direccion < 0 && mirandoDerecha) Girar();
        }
        else
        {
            animator.SetBool("correr", false);
            animator.SetBool("quieto", true);
        }
    }

    public void Saltar()
    {
        if (saltosRestantes > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            animator.SetBool("saltar", true);
            saltosRestantes--;
        }
    }

}
