using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOpponents : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] Rigidbody Girlrb;
    [SerializeField] float force;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Engel")
        {
            Player.transform.position = respawnPoint.transform.position;
        }
        if (other.tag =="Rotator")
        {
           Girlrb.AddForce(0, force, 0, ForceMode.Impulse);
        }
        if (other.tag =="RotatingStick")
        {
            Girlrb.AddForce(0, force, 0, ForceMode.Impulse);
        }
        
    }
}
