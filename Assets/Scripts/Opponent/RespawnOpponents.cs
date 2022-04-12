using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOpponents : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Engel")
        {
            Player.transform.position = respawnPoint.transform.position;
        }
        
    }
}
