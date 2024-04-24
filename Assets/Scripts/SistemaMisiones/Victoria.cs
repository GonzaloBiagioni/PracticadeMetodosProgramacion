using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    public GameObject ganaste;
    public GameObject textoMision;
    public GameObject replayboton;
    public Transform posicionInicial;
    public GameObject personaje;
    public GameObject triggerperdiste;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ganaste.SetActive(true);    
            textoMision.SetActive(false);
            replayboton.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void replay()
    {
        Time.timeScale = 1f;
        replayboton.SetActive(false);
        ganaste.SetActive(false);      
        triggerperdiste.SetActive(false);
        if (posicionInicial != null && personaje != null)
        {
            personaje.transform.position = posicionInicial.position;
        }
    }
}
