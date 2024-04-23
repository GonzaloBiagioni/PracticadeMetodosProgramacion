using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    private ActualizarPuntaje sistemaDePuntuacion;

    private void Start()
    {
        sistemaDePuntuacion = FindObjectOfType<ActualizarPuntaje>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {        
        if (other.CompareTag("Moneda"))
        {             
            Destroy(other.gameObject);     
            
            sistemaDePuntuacion.actualizarPuntaje(1);
        }
    }


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