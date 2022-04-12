using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionController : MonoBehaviour
{
    
    [SerializeField] GameObject PaintWall;
    [SerializeField] GameObject Cam1;
    [SerializeField] GameObject Cam2;
    PlayerMovement PlayerMovement;
    private void Start()
    {
        PaintWall.SetActive(false);
        PlayerMovement = GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Engel")
        {
            SceneManager.LoadScene(0);
        }
        if (other.tag=="Finish")
        {
            
            PaintWall.SetActive(true);
            //Cam1.SetActive(false);
            //Cam2.SetActive(true);
            PlayerMovement.MovementZero();
            
            
         
        }
    }
    
}
