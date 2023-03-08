using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

public class zoomOut : MonoBehaviour
{
    CinemachineVirtualCamera vcam;
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
    }

    public void onZoomOut(InputAction.CallbackContext context){
        if(context.started){
            vcam.Priority *= -1;
        }
    }
}
