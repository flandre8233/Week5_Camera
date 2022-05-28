using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Camera TargetCamera;
    private CharacterController controller;
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    public Gamepad gamepad;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        // Rotate around y - axis
        //transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        ;
        Vector3 HorizontalDir = TargetCamera.transform.TransformDirection(Vector3.right);
        float HcurSpeed = speed * Gamepad.current.leftStick.ReadValue().x;

        Vector3 VerticalDir = TargetCamera.transform.TransformDirection(Vector3.forward);
        float VcurSpeed = speed * Gamepad.current.leftStick.ReadValue().y;
        controller.SimpleMove((HorizontalDir * HcurSpeed) + (VerticalDir * VcurSpeed));
    }
}
