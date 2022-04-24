using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] CameraController CameraController;
    [SerializeField] Camera cam;
    [SerializeField] float MovementForce;
    


    public Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }


        public void MoveCharacter()
        {
            if (CameraController.isPaintCamera)
            {
                return;
            }
            if (Input.GetMouseButton(0))
            {
                transform.Translate(Vector3.forward * MovementForce * Time.deltaTime);

                Vector3 inputPosition = Input.mousePosition;
                Vector3 screenPoint = cam.WorldToScreenPoint(transform.position);
                Vector2 offset = new Vector2(inputPosition.x - screenPoint.x, inputPosition.y - screenPoint.y);
                float TargetAngle = Mathf.Atan2(offset.x, offset.y) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, TargetAngle, 0);
                Anim.SetBool("isRunning", true);
            }
            else
            {
                Anim.SetBool("isRunning", false);
            }
        }

            public void StayAnimation()
             {
            Anim.SetBool("isRunning", false);
             }


    }

