using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerCollisionController : MonoBehaviour
{
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
    
    private void Start()
    {
        TextMesh.gameObject.SetActive(false);
        text.enabled = false;
        EndGameTextt.gameObject.SetActive(false);
        EndGameText.enabled = false;
        RestartButtton.gameObject.SetActive(false);
        Restart.enabled = false;
        Cam2.SetActive(false);
        PaintWall.SetActive(false);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Engel")
        {
            SceneManager.LoadScene(1);
        }
        if (other.tag=="Finish")
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

}
