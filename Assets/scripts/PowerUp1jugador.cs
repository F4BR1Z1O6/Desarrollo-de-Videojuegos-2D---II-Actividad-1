using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoAumentoVelocidad : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("JUGADOR"))
        {
            Destroy(gameObject);
        }
    }
}