using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int manzanas = 0;
    public int bananas = 0;
    public int sandias = 0;
    public int cerezas = 0;
    public int kiwis = 0;
    public int anana = 0;
    public int frutilla = 0;
    public int naranjas = 0;

    void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SumarManzana()
    {
        manzanas++; 
    }

    public void SumarBanana()
    {
        bananas++; 
    }

    public void SumarSandia()
    {
        sandias++;       
    }

    public void SumarCereza()
    {
        cerezas++;
    }

    public void Sumarkiwi()
    {
        kiwis++;
    }

    public void SumarAnana()
    {
        anana++;
    }

    public void SumarFrutilla()
    {
        frutilla++;
    }

    public void SumarNaranja()
    {
        naranjas++;
    }
}
