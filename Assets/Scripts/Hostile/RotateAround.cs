using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target; // El objeto alrededor del cual rotar
    public float speed = 50.0f; // Velocidad de rotación
    public int damage = 1;
    void Update()
    {
        // Rota el objeto alrededor del target en el eje Z
        transform.RotateAround(target.position, Vector3.forward, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}

