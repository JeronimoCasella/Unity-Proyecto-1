using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActivarObjetoConAnimacion : MonoBehaviour
{
    public GameObject objetoAActivar; // El objeto que se activar� y har� la animaci�n

    // M�todo que se llama cuando otro Collider2D entra en el trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto que entr� al trigger tiene el tag "Player"
        if (collision.CompareTag("Player"))
        {
            // Activa el objeto
            Debug.Log("Player entered trigger");
            objetoAActivar.SetActive(true);
           
        }
    }
}
