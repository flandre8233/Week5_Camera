using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPSCameraMouseRotation : MonoBehaviour
{
    [SerializeField] Camera TargetCamera;

    public float sensitivity = 10f;
    public float minimumY = -60F;
    public float maximumY = 60F;

    float rotationX;
    float rotationY;

    void Start()
    {
        rotationX = TargetCamera.transform.eulerAngles.y;
        rotationY = -TargetCamera.transform.eulerAngles.x;
    }

    private void Update()
    {
        FPSCameraControll();
    }

    void FPSCameraControll()
    {
        rotationX += Gamepad.current.rightStick.ReadValue().x * sensitivity;
        rotationY += Gamepad.current.rightStick.ReadValue().y * sensitivity;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
        TargetCamera.transform.eulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
