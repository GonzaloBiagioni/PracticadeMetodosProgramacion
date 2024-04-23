using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public float tiempoDestruccion = 2f;

    // Metodo para disparar un proyectil con una posición inicial y velocidad específicas
    public void DispararProyectil(Vector3 posicionInicial, float velocidad)
    {
        GameObject proyectil = Instantiate(proyectilPrefab, posicionInicial, Quaternion.identity);
       
        Rigidbody2D rbProyectil = proyectil.GetComponent<Rigidbody2D>();

        rbProyectil.velocity = transform.right * velocidad;

        Destroy(proyectil, tiempoDestruccion);
    }
}