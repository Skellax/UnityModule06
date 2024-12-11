using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwitchCam : MonoBehaviour
{
    public Transform player;
    public CinemachineVirtualCamera vCamera;

    //Active the camera when the player enter the collider
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            vCamera.Priority = 1;
        }
    }

    //Disactive the camera when the player enter the collider

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            vCamera.Priority = 0;
        }
    }
    
}
