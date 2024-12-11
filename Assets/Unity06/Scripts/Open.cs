using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public Animator doorAnimator;
    public Transform door;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            if (door.rotation.y == 0) {
                if (other.transform.position.z < transform.position.z) {
                    doorAnimator.SetBool("isOpen1", true);
                }
                else {
                    doorAnimator.SetBool("isOpen2", true);
                }
            }
            else{
                if (other.transform.position.x < transform.position.x) {
                    doorAnimator.SetBool("isOpen1", true);
                }
                else {
                    doorAnimator.SetBool("isOpen2", true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            doorAnimator.SetBool("isOpen1", false);
            doorAnimator.SetBool("isOpen2", false);
        }
    }
   
}
