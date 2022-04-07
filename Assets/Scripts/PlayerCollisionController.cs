using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionController : MonoBehaviour
{
    
    [SerializeField] GameObject PaintWall;
    private void Start()
    {
        PaintWall.SetActive(false);
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
        }
    }
    
}
