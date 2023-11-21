using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFloat : MonoBehaviour
{
    public Camera arCamera;
    public float distanceFromCamera = 2.0f;
    void Update()
    {
        transform.position = arCamera.transform.position + arCamera.transform.forward * distanceFromCamera;
    }
}
