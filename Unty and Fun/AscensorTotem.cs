using UnityEngine;

public class AscensorTotem : MonoBehaviour
{
    public float velocidad = 2f;
    public float altura = 3f;
    public string nombreParametroAnimacion = "Activar";

    private Vector3 posicionInicial;
    private bool subir = true;
    private Animator anim;

    void Start()
    {
        posicionInicial = transform.position;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Movimiento arriba y abajo desde que empieza el juego
        if (subir)
        {
            transform.position += Vector3.up * velocidad * Time.deltaTime;
            if (transform.position.y >= posicionInicial.y + altura)
                subir = false;
        }
        else
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;
            if (transform.position.y <= posicionInicial.y)
                subir = true;
        }
    }

    
}
