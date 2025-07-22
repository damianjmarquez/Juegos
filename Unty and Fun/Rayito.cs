using UnityEngine;

public class Rayito : MonoBehaviour
{
    public bool destruirAlTocar = true; // Activ�s o desactiv�s desde el Inspector

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("personaje"))
        {
            ParpadeoPersonaje parpadeo = other.GetComponent<ParpadeoPersonaje>();
            if (parpadeo != null)
            {
                parpadeo.RecibirDa�o();
            }

            if (destruirAlTocar)
            {
                Destroy(gameObject);
            }
        }
    }
}
