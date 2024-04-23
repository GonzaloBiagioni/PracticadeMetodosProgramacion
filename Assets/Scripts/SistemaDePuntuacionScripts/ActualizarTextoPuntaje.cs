using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarTextoPuntaje : MonoBehaviour
{
    public TMP_Text textoPuntaje;
    public ActualizarPuntaje sistemaDePuntuacion; 

    private void Update()
    {

        int puntajeActual = sistemaDePuntuacion.ObtenerPuntaje();

        textoPuntaje.text = "Puntaje: " + puntajeActual.ToString();
    }
}