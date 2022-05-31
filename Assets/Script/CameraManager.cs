using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtualCamera0;
    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtualCamera1;
    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtualCamera2;
    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtualCamera3;
    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtualCamera4;


    private IEnumerator  Start()
    {
        yield return new WaitForSeconds(1);
        _cinemachineVirtualCamera0.Priority = 10;
        yield return new WaitForSeconds(2);
        _cinemachineVirtualCamera1.Priority = 20;
    }
}
