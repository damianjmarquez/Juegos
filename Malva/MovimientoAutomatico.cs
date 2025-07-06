using UnityEngine;

public class MovimientoAutomatico : MonoBehaviour
{
    public float velocidad = 3f;
    public bool mirarDerecha = true;

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        if (!mirarDerecha)
        {
            Vector3 escala = transform.localScale;
            escala.x *= -1;
            transform.localScale = escala;
        }
    }

    void Update()
    {
        float direccion = mirarDerecha ? 1f : -1f;
        rb.velocity = new Vector2(direccion * velocidad, rb.velocity.y);

        animator.SetBool("correr", true);
    }
}
