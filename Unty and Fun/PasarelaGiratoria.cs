using UnityEngine;

public class PasarelaGiratoria : MonoBehaviour
{
    public float velocidad = 2f;
    public float distancia = 3f;

    private Vector3 posicionInicial;
    private bool haciaDerecha = true;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (haciaDerecha)
        {
            transform.Translate(Vector2.right * velocidad * Time.deltaTime);
            if (transform.position.x >= posicionInicial.x + distancia)
                haciaDerecha = false;
        }
        else
        {
            transform.Translate(Vector2.left * velocidad * Time.deltaTime);
            if (transform.position.x <= posicionInicial.x - distancia)
                haciaDerecha = true;
        }
    }
}
