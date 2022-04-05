using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        Sequence Obstacle = DOTween.Sequence();
        Obstacle.Append(transform.DOMoveX(5, 1));
        Obstacle.Append(transform.DOMoveX(0, 1));
        Obstacle.SetLoops(-1);

    }

    
}
