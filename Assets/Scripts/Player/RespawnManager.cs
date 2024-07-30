using System.Collections;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public static RespawnManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public GameObject playerPrefab; // Prefab del jugador
    public Transform respawnPoint;  // Punto de respawn
    public float respawnDelay = 2f; // Tiempo de espera antes del respawn

    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCoroutine());
    }

    private IEnumerator RespawnCoroutine()
    {
        yield return new WaitForSeconds(respawnDelay);

        GameObject newPlayer = Instantiate(playerPrefab, respawnPoint.position, respawnPoint.rotation);

        // Actualiza la cámara para que siga al nuevo jugador
        CameraController.instance.SetNewFollowTarget(newPlayer.transform);
    }
}