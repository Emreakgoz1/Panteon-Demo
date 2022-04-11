using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleHorizontal : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float RotationDistance;
    [SerializeField] float RotationBack;
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        Sequence Obstacle = DOTween.Sequence();
        Obstacle.Append(transform.DOMoveX(RotationDistance,speed));
        Obstacle.Append(transform.DOMoveX(RotationBack,speed));
        Obstacle.SetLoops(-1);
    }

}
