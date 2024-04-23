using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarPuntaje : MonoBehaviour
{
    private int puntaje = 0;

    // Metodo para actualizar el puntaje
    public void actualizarPuntaje(int puntos)
    {
        puntaje += puntos; 
    }

    // Metodo para obtener el puntaje actual
    public int ObtenerPuntaje()
    {
        return puntaje;
    }
}