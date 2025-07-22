using UnityEngine;

public class Rayito : MonoBehaviour
{
    public bool destruirAlTocar = true; // Activás o desactivás desde el Inspector

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("personaje"))
        {
            ParpadeoPersonaje parpadeo = other.GetComponent<ParpadeoPersonaje>();
            if (parpadeo != null)
            {
                parpadeo.RecibirDaño();
            }

            if (destruirAlTocar)
            {
                Destroy(gameObject);
            }
        }
    }
}
