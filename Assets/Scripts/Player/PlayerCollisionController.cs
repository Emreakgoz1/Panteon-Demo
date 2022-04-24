using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerCollisionController : MonoBehaviour
{
    public Uimanager Uimanager;
    public PlayerMove PlayerMove;
    public CameraController CameraController;

    [SerializeField] float force;
    [SerializeField] GameObject PaintWall;
    [SerializeField] GameObject Pie;
    [SerializeField] GameObject FinishLine;

    Rigidbody PlayerRb;

    public void Start()
    {
        Pie.SetActive(false);
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
            Pie.SetActive(true);
            PlayerMove.StayAnimation();
            FinishLine.SetActive(false);
         
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
