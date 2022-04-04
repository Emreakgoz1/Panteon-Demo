using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] GameObject Obstacle;
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        //Obstacle.transform.DOMoveX(9, 1);
        
        for (int i = 0; i < 20; i++)
        {
            Sequence Obstacle = DOTween.Sequence();
            Obstacle.Append(transform.DOMoveX(9, 1).SetLoops(-1));
            Obstacle.Append(transform.DOMoveX(0, 1)).SetLoops(-1);
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
