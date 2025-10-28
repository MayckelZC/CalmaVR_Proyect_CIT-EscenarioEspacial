using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderAlien : MonoBehaviour
{

    public GameObject panelActivar;
    public GameObject panelDesactivar;
    public string playerTag = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (panelActivar != null)
            {
                panelActivar.SetActive(true);
            }            
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (panelActivar != null)
            {
                panelActivar.SetActive(false);
            }   
        }

        if (other.CompareTag(playerTag))
        {
            if (panelDesactivar != null)
            {
                panelDesactivar.SetActive(false);
            }
        }
    }
}
