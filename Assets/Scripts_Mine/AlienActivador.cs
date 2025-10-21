using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; // Necesario para la interacción VR

public class AlienActivador : MonoBehaviour
{
    public GameObject menuRespiracionUI; // Ranura para arrastrar el Canvas
    private XRSimpleInteractable interactable;

    void Start()
    {
        // El Alien necesita un Collider para ser interactivo.
        if (GetComponent<Collider>() == null)
        {
            Debug.LogError("¡El Alien no tiene Collider! No puede ser activado.");
            return;
        }

        interactable = GetComponent<XRSimpleInteractable>();
        if (interactable != null)
        {
            // Suscribir al evento de interacción (cuando el rayo toca y activa)
            interactable.activated.AddListener(MostrarMenu);
        }
    }

    private void MostrarMenu(ActivateEventArgs arg)
    {
        // Muestra el Canvas y, opcionalmente, lo acerca a la vista del jugador.
        if (menuRespiracionUI != null)
        {
            menuRespiracionUI.SetActive(true);
            // Time.timeScale = 0f; // Puedes pausar el juego para interaccion UI
        }
    }

    // Función llamada por el botón 'NO' (oculta el UI)
    public void OcultarMenu()
    {
        if (menuRespiracionUI != null)
        {
            menuRespiracionUI.SetActive(false);
            // Time.timeScale = 1f; // Reanuda el juego
        }
    }
}