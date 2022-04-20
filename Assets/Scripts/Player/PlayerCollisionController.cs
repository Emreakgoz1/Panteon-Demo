using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerCollisionController : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] CameraController CameraController;
    [SerializeField] GameObject PaintWall;
    [SerializeField] GameObject Cam1;
    [SerializeField] GameObject Cam2;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI EndGameText;
    [SerializeField] GameObject EndGameTextt;
    [SerializeField] GameObject TextMesh;
    [SerializeField] Button Restart;
    [SerializeField] GameObject RestartButtton;
    [SerializeField] float Pushpower;
    [SerializeField] float rotateSpeedOnThePlatform;
    [SerializeField] float pforce;

    Vector3 desiredVelocity;
    Rigidbody PlayerRb;
    // private RigidbodyConstraints originalConstraints;



    private void Start()
    {
        
        PlayerRb = GetComponent<Rigidbody>();
        TextMesh.gameObject.SetActive(false);
        text.enabled = false;
        EndGameTextt.gameObject.SetActive(false);
        EndGameText.enabled = false;
        RestartButtton.gameObject.SetActive(false);
        Restart.enabled = false;
        Cam2.SetActive(false);
        PaintWall.SetActive(false);
        
    }
    private void Update()
    {
        ObsctaclePushLeft();
        ObsctaclePushRight();
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Engel")
        {
            SceneManager.LoadScene(1);
        }
        if (collision.transform.tag == "Finish")
        {
            CameraController.isPaintCamera = true;
            TextMesh.gameObject.SetActive(true);
            text.enabled = true;
            PaintWall.SetActive(true);
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            StartCoroutine(EndGame());
            StartCoroutine(HideText());
        }
        if (collision.transform.tag == "Rotator")
        {
            ObsctaclePush();
        }
        
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(15);
        TextMesh.gameObject.SetActive(false);
        text.enabled = false;

    }

    IEnumerator HideText()
    {
        yield return new WaitForSeconds(15.5f);
        EndGameTextt.gameObject.SetActive(true);
        EndGameText.enabled = true;
        RestartButtton.gameObject.SetActive(true);
        Restart.enabled = true;
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
