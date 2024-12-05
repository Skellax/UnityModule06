using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    private float rotationSpeed = 5f;

    private Quaternion targetRotation;

    private Animator controllerAnimation;


    // Start is called before the first frame update
    void Start()
    {
        controllerAnimation = GetComponent<Animator>();
        targetRotation = transform.rotation;
    }

    //animator walking
    void WalkAnim()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0 ^ Mathf.Abs(Input.GetAxis("Vertical")) > 0) {
            controllerAnimation.SetBool("IsWalking", true);
        }
        else {
            controllerAnimation.SetBool("IsWalking", false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0 && vertical == 0) // turn right
        {
            targetRotation = Quaternion.Euler(0, 90, 0);
        }
        else if (horizontal < 0 && vertical == 0) // turn left
        {
            targetRotation = Quaternion.Euler(0, -90, 0);
        }
        else if (vertical > 0 && horizontal == 0) // turn up 
        {
            targetRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (vertical < 0 && horizontal == 0) // turn down
        {
            targetRotation = Quaternion.Euler(0, 180, 0);
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        WalkAnim();
    }   
}
