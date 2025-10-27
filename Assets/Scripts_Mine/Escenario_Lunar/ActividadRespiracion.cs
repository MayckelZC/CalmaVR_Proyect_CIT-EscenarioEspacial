using System.Collections;
using TMPro;
using UnityEngine;

public class ActividadRespiracion : MonoBehaviour
{
    public TextMeshProUGUI txtActividad;

    public void IniciarActividad()
    {
        StartCoroutine(CambiarTexto());
    }
    

    IEnumerator CambiarTexto()
    {
        txtActividad.text = "Inhala...";
        yield return new WaitForSeconds(4f);

        txtActividad.text = "Mantén...";
        yield return new WaitForSeconds(7f);

        txtActividad.text = "Exhala...";
        yield return new WaitForSeconds(8f);

        txtActividad.text = "Relájate...";
    }
}