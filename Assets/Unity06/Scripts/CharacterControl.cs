using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    private float rotationSpeed = 5f;

    private Quaternion targetRotation;

    private Animator controllerAnimation;

    private Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        controllerAnimation = GetComponent<Animator>();
        targetRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();

        rb.isKinematic = true;
    }

    //Move the character
    void WalkAnim()
    {
        if ((Input.GetAxis("Vertical")) > 0) {
            rb.isKinematic = false;
            controllerAnimation.SetBool("IsWalking", true);
        }
        else {
            controllerAnimation.SetBool("IsWalking", false);
            rb.isKinematic = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0 ) // turn right
        {
            targetRotation = Quaternion.Euler(0,transform.eulerAngles.y + 20, 0);
        }
        else if (horizontal < 0) //turn left
        {
            targetRotation = Quaternion.Euler(0,transform.eulerAngles.y - 20, 0);
        }
        else if (horizontal == 0 && vertical < 0) // turn down
        {
            targetRotation = Quaternion.Euler(0,transform.eulerAngles.y +  180, 0);
        }
        

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        WalkAnim();
    }   
}
