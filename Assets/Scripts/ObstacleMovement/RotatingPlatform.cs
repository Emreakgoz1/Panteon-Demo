using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotatingPlatform : MonoBehaviour
{
    public float speed = 50;
    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
    }
}
