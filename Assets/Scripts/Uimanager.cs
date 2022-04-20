using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Uimanager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI EndGameText;
    [SerializeField] GameObject EndGameTextt;
    [SerializeField] GameObject TextMesh;
    [SerializeField] Button Restart;
    [SerializeField] GameObject RestartButtton;
    // Start is called before the first frame update
    void Start()
    {
        TextMesh.gameObject.SetActive(false);
        text.enabled = false;
        EndGameTextt.gameObject.SetActive(false);
        EndGameText.enabled = false;
        RestartButtton.gameObject.SetActive(false);
        Restart.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetActiveText()
    {
        TextMesh.gameObject.SetActive(true);
        text.enabled = true;
        
    }
}
