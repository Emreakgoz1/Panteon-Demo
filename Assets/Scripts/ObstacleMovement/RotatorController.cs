using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorController : MonoBehaviour
{
    public float speed = 50;
    [SerializeField] float rotateSpeedOnThePlatform;
    private void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, Mathf.Infinity))
        {
            //Rotate with rotating platform 
            if (hit.transform.tag == "Rotating Platform")
            {
                int platformRotateDir = hit.transform.gameObject.GetComponent<RotatingPlatform>().speed < 0 ? -1 : 1;
                transform.RotateAround(hit.transform.position, platformRotateDir * Vector3.forward, rotateSpeedOnThePlatform * Time.deltaTime);
            }
        }
    }
}
