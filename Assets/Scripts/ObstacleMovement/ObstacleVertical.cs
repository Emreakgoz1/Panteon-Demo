using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleVertical : MonoBehaviour
{
         [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        Sequence Obstacle = DOTween.Sequence();
        Obstacle.Append(transform.DOMoveZ(15, speed));
        Obstacle.Append(transform.DOMoveZ(23, speed));
        Obstacle.SetLoops(-1);
    }

    
}
