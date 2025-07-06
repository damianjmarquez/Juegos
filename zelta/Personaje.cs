using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private BoxCollider2D colEspada;
    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer spritePersonaje;
    private float posColX = 1;
    private float posColY = 0;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>(); 
        anim = GetComponentInChildren<Animator>();
        spritePersonaje = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            anim.SetTrigger("Ataca");
        }
    }

    private void FixedUpdate()
    {
        movimiento();
    }

    private void movimiento()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        rig.velocity = new Vector2(Horizontal, Vertical) * velocidad;
        anim.SetFloat("Camina", Mathf.Abs(rig.velocity.magnitude));

        if (Horizontal > 0)
        {
            colEspada.offset = new Vector2(posColX, posColY);
            spritePersonaje.flipX = false;
        }
        else if (Horizontal < 0)
        {
            colEspada.offset = new Vector2(-posColX, posColY);
            spritePersonaje.flipX = true;
        }
    }
}
