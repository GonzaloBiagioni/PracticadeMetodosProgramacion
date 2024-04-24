using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador1 : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    // Metodo para actualizar el movimiento en cada frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 direccionMovimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0f).normalized;

        Vector3 posicionActual = transform.position;

        Vector3 nuevaPosicion = posicionActual + direccionMovimiento * velocidadMovimiento * Time.deltaTime;

        transform.position = nuevaPosicion;

    }
}
