using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera1;
    [SerializeField] private CinemachineVirtualCamera camera2;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TurnOnCamera(camera1, camera2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TurnOnCamera(camera2, camera1);
        }
    }

    private void TurnOnCamera(CinemachineVirtualCamera camToTurnOn, CinemachineVirtualCamera otherCamera)
    {

        camToTurnOn.gameObject.SetActive(true);
        otherCamera.gameObject.SetActive(false);

    }
}
