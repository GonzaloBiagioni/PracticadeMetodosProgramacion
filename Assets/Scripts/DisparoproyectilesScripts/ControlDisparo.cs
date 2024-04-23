using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDisparo : MonoBehaviour
{
    public Disparo disparo; 

    // Metodo para manejar la accion de disparar
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 posicionDeDisparo = transform.position;

            float velocidadDelProyectil = 20f;

            disparo.DispararProyectil(posicionDeDisparo, velocidadDelProyectil);
        }
    }
}