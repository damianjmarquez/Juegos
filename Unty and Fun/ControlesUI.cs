using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControlesUI : MonoBehaviour
{
    public static ControlesUI Instance;

    public Button botonSaltar;
    public EventTrigger botonIzquierda;
    public EventTrigger botonDerecha;

    private MovimientoPersonaje personaje;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    // Este método será llamado por el personaje cuando se instancia
    public void AsignarPersonaje(MovimientoPersonaje nuevo)
    {
        personaje = nuevo;

        // Asignamos botones si hay
        if (botonSaltar != null)
        {
            botonSaltar.onClick.RemoveAllListeners();
            botonSaltar.onClick.AddListener(() => personaje.Saltar());
        }

        if (botonIzquierda != null)
        {
            botonIzquierda.triggers.Clear();
            AgregarEvento(botonIzquierda, EventTriggerType.PointerDown, () => personaje.MoverIzquierda(true));
            AgregarEvento(botonIzquierda, EventTriggerType.PointerUp, () => personaje.MoverIzquierda(false));
        }

        if (botonDerecha != null)
        {
            botonDerecha.triggers.Clear();
            AgregarEvento(botonDerecha, EventTriggerType.PointerDown, () => personaje.MoverDerecha(true));
            AgregarEvento(botonDerecha, EventTriggerType.PointerUp, () => personaje.MoverDerecha(false));
        }
    }

    void AgregarEvento(EventTrigger trigger, EventTriggerType tipo, UnityEngine.Events.UnityAction accion)
    {
        var entry = new EventTrigger.Entry { eventID = tipo };
        entry.callback.AddListener((eventData) => accion());
        trigger.triggers.Add(entry);
    }
}
