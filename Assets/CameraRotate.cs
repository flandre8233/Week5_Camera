using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraRotate : MonoBehaviour
{
    public float sensitivity = 10f;

    public float Rotate = 0;

    public float minimumX = -60F;
    public float maximumX = 60F;

    float rotationX;

    void Start()
    {
        rotationX = transform.eulerAngles.y;
        minimumX = rotationX - Mathf.Abs(Rotate);
        maximumX = rotationX + Mathf.Abs(Rotate);
    }

    private void Update()
    {
        FPSCameraControll();
    }

    void FPSCameraControll()
    {
        rotationX += Mouse.current.delta.x.ReadValue() * sensitivity;
        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, rotationX, 0);
    }
}
