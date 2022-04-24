using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Uimanager : MonoBehaviour
{
    
    [SerializeField] public TextMeshProUGUI text;
    [SerializeField] public TextMeshProUGUI EndGameText;
    [SerializeField] public GameObject EndGameTextt;
    [SerializeField] public GameObject TextMesh;
    [SerializeField] public Button Restart;
    [SerializeField] public GameObject RestartButtton;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStartUi()
    {
        TextMesh.gameObject.SetActive(false);
        text.enabled = false;
        EndGameTextt.gameObject.SetActive(false);
        EndGameText.enabled = false;
        RestartButtton.gameObject.SetActive(false);
        Restart.enabled = false;
    }

   public  void PaintTheWallTextOn()
    {
        TextMesh.gameObject.SetActive(true);
        text.enabled = true;
        
    }
   public  void PaintTheWallTextOf()
    {
        TextMesh.gameObject.SetActive(false);
        text.enabled = false;
    }

   public void PaintedTheWallRestartButtonOn()
    {
        EndGameTextt.gameObject.SetActive(true);
        EndGameText.enabled = true;
        RestartButtton.gameObject.SetActive(true);
        Restart.enabled = true;
    }
    

}
