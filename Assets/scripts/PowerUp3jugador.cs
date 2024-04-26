using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetoReduccionVelocidad : MonoBehaviour
{
    public float tiempoActivacion = 21f;

    void Start()
    {
        gameObject.SetActive(false);

        Invoke("ActivarObjeto", tiempoActivacion);
    }

    void ActivarObjeto()
    {
        gameObject.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("JUGADOR"))
        {
            SceneManager.LoadScene("Ganaste"); 
        }
    }
}
