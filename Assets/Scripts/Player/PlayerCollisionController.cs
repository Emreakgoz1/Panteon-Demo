using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerCollisionController : MonoBehaviour
{
    public Uimanager Uimanager;
    [SerializeField] float force;
    [SerializeField] CameraController CameraController;
    [SerializeField] GameObject PaintWall;
    [SerializeField] GameObject Cam1;
    Rigidbody PlayerRb;



    public void Start()
    {

        Uimanager.GameStartUi();
        PlayerRb = GetComponent<Rigidbody>();
        PaintWall.SetActive(false);
        
        
    }
    public void Update()
    {
        ObsctaclePushLeft();
        ObsctaclePushRight();
    }



    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Engel")
        {
            SceneManager.LoadScene(1);
        }
        if (collision.transform.tag == "PaintPlatform")
        {
            CameraController.isPaintCamera = true;
            Uimanager.PaintTheWallTextOn();
            PaintWall.SetActive(true);
 
     
        }
        if (collision.transform.tag == "Rotator")
        {
            ObsctaclePush();
        }
        
    }

    void ObsctaclePush()
    {
        PlayerRb.AddForce(0, force, 0, ForceMode.Impulse);
    }
    void ObsctaclePushLeft()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,-transform.up,out hit))
        {
            if (hit.transform.tag=="RotatingObstacle")
            {
                    PlayerRb.velocity = new Vector3(-2, 0, 0);
            }
        }
 
    }
    void ObsctaclePushRight()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,-transform.up, out hit))
        {
            if (hit.transform.tag == "RotatingObstacleleft")
            {
                PlayerRb.velocity = new Vector3(2, 0, 0);
            }
        }


    }
    
    


}
