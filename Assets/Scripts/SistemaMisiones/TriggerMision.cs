using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerMision : MonoBehaviour
{
    public GameObject activarMision;
    public GameObject completarMision;
    private bool misionActivada = false;
    public GameObject winElement;
    public GameObject triggerperdiste;
    public GameObject cancelarmision;

    private void Awake()
    {
        triggerperdiste.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (!misionActivada)
            {
                misionActivada = true;
                cancelarmision.SetActive(false);
                activarMision.SetActive(true);
                triggerperdiste.SetActive(true);
                winElement.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            misionActivada = false;
            activarMision.SetActive(false);            
            winElement.SetActive(false);
        }
    }

}
