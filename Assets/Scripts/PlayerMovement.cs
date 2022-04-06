using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{
    float Horizontal;

    float Vertical;
    

    public bool SwitchMove = false;

    float turnSmoothVelocity;
    bool isjumping = false;
    [SerializeField] Transform model;

    [SerializeField] float MovementForce = 10f;
    [SerializeField] float SmoothTurnTime = 0.1f;
    [SerializeField] float jumppower;

    Vector3 direction;

    Rigidbody rb;
    

    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        rb = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        direction = new Vector3(Horizontal, 0, Vertical);
        rb.MovePosition(transform.position + (direction * MovementForce * Time.fixedDeltaTime));
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isjumping)
            {
                //PlayerAnim.SetTrigger("jump");
                //PlayerAnim.SetBool("isGround", true);

                isjumping = true;
                model.DOLocalJump(model.localPosition, jumppower, 1, 1).OnComplete(() =>
                {
                    isjumping = false;
                });
            }
            
        }

        if (direction.magnitude > 0.01f)
        {
            float targetAngle;

            if (!SwitchMove)
            {
                targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            }
            else
            {
                targetAngle = Mathf.Atan2(-direction.x,-direction.z) * Mathf.Rad2Deg;
            }

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, SmoothTurnTime);
            transform.rotation = Quaternion.Euler(0f,angle,0f);

            Anim.SetBool("isRunning", true);

        }
        else
        {
            Anim.SetBool("isRunning", false);
        }

       


    }
    

}
