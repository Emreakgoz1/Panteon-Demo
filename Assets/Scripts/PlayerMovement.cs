using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float Horizontal;

    float Vertical;

    [SerializeField] float MovementForce = 10f;

    float turnSmoothVelocity;

    [SerializeField] float SmoothTurnTime = 0.1f;

    public bool SwitchMove = false;

    Vector3 direction;

    CharacterController cb;

    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        cb = GetComponent<CharacterController>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        direction = new Vector3(Horizontal, 0, Vertical);
        cb.Move(direction * Time.deltaTime * MovementForce);

        

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
