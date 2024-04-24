using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public TMP_Text cantidadMoneda1;
    public TMP_Text cantidadMoneda2;
    public TMP_Text cantidadMoneda3;

    private List<string> nombresMonedas = new List<string> { "Moneda1", "Moneda2", "Moneda3" };
    private List<int> cantidadesMonedas = new List<int> { 0, 0, 0 };

    void Start()
    {
        // Asignar métodos a los botones
        AsignarMetodoBoton("BotonAgregar1", "Moneda1", AgregarMoneda);
        AsignarMetodoBoton("BotonRestar1", "Moneda1", RestarMoneda);

        AsignarMetodoBoton("BotonAgregar2", "Moneda2", AgregarMoneda);
        AsignarMetodoBoton("BotonRestar2", "Moneda2", RestarMoneda);

        AsignarMetodoBoton("BotonAgregar3", "Moneda3", AgregarMoneda);
        AsignarMetodoBoton("BotonRestar3", "Moneda3", RestarMoneda);

        ActualizarTextos();
    }

    void AsignarMetodoBoton(string nombreBoton, string nombreMoneda, UnityAction<string> metodo)
    {
        GameObject.Find(nombreBoton).GetComponent<Button>().onClick.AddListener(() => metodo(nombreMoneda));
    }

    public void AgregarMoneda(string nombreMoneda)
    {
        int indice = nombresMonedas.IndexOf(nombreMoneda);
        if (indice != -1)
        {
            cantidadesMonedas[indice]++;
            ActualizarTextos();
        }
    }

    public void RestarMoneda(string nombreMoneda)
    {
        int indice = nombresMonedas.IndexOf(nombreMoneda);
        if (indice != -1 && cantidadesMonedas[indice] > 0)
        {
            cantidadesMonedas[indice]--;
            ActualizarTextos();
        }
    }

    void ActualizarTextos()
    {
        cantidadMoneda1.text = "Moneda Roja: " + cantidadesMonedas[0].ToString();
        cantidadMoneda2.text = "Moneda Azul: " + cantidadesMonedas[1].ToString();
        cantidadMoneda3.text = "Moneda Verde: " + cantidadesMonedas[2].ToString();
    }
}
