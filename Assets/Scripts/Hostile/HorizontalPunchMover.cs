using UnityEngine;
using System.Collections;

public class HorizontalPunchMover : MonoBehaviour
{
    public float speed = 10.0f; // Velocidad del golpe
    public float distance = 2.0f; // Distancia del golpe
    public float pauseTime = 2.0f; // Tiempo de pausa en segundos

    private Vector3 startPos;
    public int damage = 1;

    void Start()
    {
        startPos = transform.position;
        StartCoroutine(PunchMovement());
    }


    IEnumerator PunchMovement()
    {
        while (true)
        {
            // Golpe hacia la derecha
            yield return StartCoroutine(MoveTo(startPos.x + distance));
            yield return new WaitForSeconds(pauseTime);

            // Golpe hacia la izquierda
            yield return StartCoroutine(MoveTo(startPos.x - distance));
            yield return new WaitForSeconds(pauseTime);
        }
    }

    IEnumerator MoveTo(float targetX)
    {
        Vector3 targetPos = new Vector3(targetX, startPos.y, startPos.z);
        while (Mathf.Abs(transform.position.x - targetX) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            yield return null;
        }
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