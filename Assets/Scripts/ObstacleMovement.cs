using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        Sequence Obstacle = DOTween.Sequence();
        Obstacle.Append(transform.DOMoveX(5, speed));
        Obstacle.Append(transform.DOMoveX(0, speed));
        Obstacle.SetLoops(-1);

    }

    
}
