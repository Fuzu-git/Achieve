using System;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    private bool hasAlreadyRespawned = false; 

    public static Action playerRespawned; 
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;

        if (!hasAlreadyRespawned)
        {
            playerRespawned?.Invoke();
            hasAlreadyRespawned = true; 
        }
    }
}
