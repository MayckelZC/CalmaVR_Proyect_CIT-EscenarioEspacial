using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActividadRespiracion : MonoBehaviour
{   

    //Variables publicas
    public TextMeshProUGUI txtActividad;
    public GameObject iniciarAct;
    public GameObject actividad;
    public string playerTag = "Player";


    private List<(string texto, float duracion)> pasos = new()
    {   

        //Inicio de actividad
        ("La actividad va a empezar en 3", 1f),
        ("La actividad va a empezar en 2", 1f),
        ("La actividad va a empezar en 1", 1f),

        //Inhala
        ("Inhala...\n4", 1f),
        ("Inhala...\n3", 1f),
        ("Inhala...\n2", 1f),
        ("Inhala...\n1", 1f),

        //Mantener
        ("Mantén...\n7", 1f),
        ("Mantén...\n6", 1f),
        ("Mantén...\n5", 1f),
        ("Mantén...\n4", 1f),
        ("Mantén...\n3", 1f),
        ("Mantén...\n2", 1f),
        ("Mantén...\n1", 1f),

        //Exhala    
        ("Exhala...\n8", 1f),
        ("Exhala...\n7", 1f),
        ("Exhala...\n6", 1f),
        ("Exhala...\n5", 1f),
        ("Exhala...\n4", 1f),
        ("Exhala...\n3", 1f),
        ("Exhala...\n2", 1f),
        ("Exhala...\n1", 1f),
        ("Relájate...", 5f)
    };
    public void IniciarActividad()
    {
        StartCoroutine(CambiarTexto());
    }


    IEnumerator CambiarTexto()
    {
        foreach (var paso in pasos)
        {
            txtActividad.text = paso.texto;
            yield return new WaitForSeconds(paso.duracion);
        }

        //Volver al primer canvas
  
        iniciarAct.SetActive(true);
        actividad.SetActive(false);


    }
}