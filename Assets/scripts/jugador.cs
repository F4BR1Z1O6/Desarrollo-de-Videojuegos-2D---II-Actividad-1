using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    //private Vector3 posicionInicial;

    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0f).normalized * velocidadMovimiento;

        // Aplicar el movimiento al objeto
        transform.Translate(movimiento * Time.deltaTime, Space.World);
    }

    public void ReducirVelocidad(float reduccion, float duracion, Color nuevoColor)
    {
        StartCoroutine(ReduceSpeedCoroutine(reduccion, duracion, nuevoColor));
    }

    public void AumentarVelocidad(float aumento, float duracion, Color nuevoColor)
    {
        StartCoroutine(IncreaseSpeedCoroutine(aumento, duracion, nuevoColor));
    }

    public void ResetearPosicion(Vector3 nuevaPosicion)
    {
        // Restaurar la posición del jugador a la nueva posición
        transform.position = nuevaPosicion;
    }

    private IEnumerator ReduceSpeedCoroutine(float reduccion, float duracion, Color nuevoColor)
    {
        velocidadMovimiento -= reduccion;
        GetComponent<SpriteRenderer>().color = nuevoColor;

        yield return new WaitForSeconds(duracion);

        velocidadMovimiento += reduccion;
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private IEnumerator IncreaseSpeedCoroutine(float aumento, float duracion, Color nuevoColor)
    {
        velocidadMovimiento += aumento;
        GetComponent<SpriteRenderer>().color = nuevoColor;

        yield return new WaitForSeconds(duracion);

        velocidadMovimiento -= aumento;
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    internal void ResetearPosicion(double v1, double v2)
    {
        throw new NotImplementedException();
    }
}

