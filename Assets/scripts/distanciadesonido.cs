using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanciadesonido : MonoBehaviour
{
    public AudioSource audioSource;
    public Transform jugador;
    public float distanciaMaxima = 5f;

    void Update()
    {
        float distancia = Vector3.Distance(transform.position, jugador.position);
        float volumen = 1f - (distancia / distanciaMaxima); // Ajusta la distancia máxima según lo que necesites

        if (volumen < 0f) volumen = 0f;
        audioSource.volume = volumen;
    }
}

