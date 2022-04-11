using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleMovement2 : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        Sequence Obstacle = DOTween.Sequence();
        Obstacle.Append(transform.DOMoveX(5,speed));
        Obstacle.Append(transform.DOMoveX(9.6f,speed));
        Obstacle.SetLoops(-1);
    }

}
