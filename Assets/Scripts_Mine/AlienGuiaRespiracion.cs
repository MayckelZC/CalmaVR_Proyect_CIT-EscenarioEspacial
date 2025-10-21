using UnityEngine;
using System.Collections;
using TMPro; 

public class AlienGuiaRespiracion : MonoBehaviour
{
    // Duraciones de la técnica 4-7-8
    private const float INHALE_TIME = 4f;
    private const float HOLD_IN_TIME = 7f;
    private const float EXHALE_TIME = 8f;
    private const float PAUSE_TIME = 1f; // Pausa antes de repetir

    // Conexión al texto 3D flotante (Asignar en el Inspector)
    public TMP_Text statusText; 
    
    // El método Start() será llamado al presionar 'SÍ' en el menú activador
    public void IniciarSesion()
    {
        // Detiene cualquier ciclo anterior y comienza uno nuevo
        StopAllCoroutines(); 
        StartCoroutine(RespirationCycle());
        
        // Opcional: Oculta el menú UI del activador aquí
        // Por ejemplo: FindObjectOfType<AlienActivador>().OcultarMenu();
    }
    
    // Método para detener la sesión si es necesario
    public void DetenerSesion()
    {
        StopAllCoroutines();
        if (statusText != null) statusText.text = "Sesión finalizada. ¡Bien hecho!";
    }

    IEnumerator RespirationCycle()
    {
        // Mensaje de preparación
        if (statusText != null) statusText.text = "Preparate...";
        yield return new WaitForSeconds(2f); 

        while (true)
        {
            // 1. INHALAR (4 segundos)
            if (statusText != null) statusText.text = "<size=120%>INHALA</size>\n<size=80%>(4 SEGUNDOS)</size>";
            yield return new WaitForSeconds(INHALE_TIME);

            // 2. RETENER (7 segundos)
            if (statusText != null) statusText.text = "<size=120%>RETÉN</size>\n<size=80%>(7 SEGUNDOS)</size>";
            yield return new WaitForSeconds(HOLD_IN_TIME);

            // 3. EXHALAR (8 segundos)
            if (statusText != null) statusText.text = "<size=120%>EXHALA</size>\n<size=80%>(8 SEGUNDOS)</size>";
            yield return new WaitForSeconds(EXHALE_TIME);

            // 4. PAUSA (1 segundo)
            if (statusText != null) statusText.text = "PAUSA";
            yield return new WaitForSeconds(PAUSE_TIME);
        }
    }
}