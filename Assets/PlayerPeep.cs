using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerPeep : MonoBehaviour
{
    [SerializeField] GameObject LeftPeep;
    [SerializeField] GameObject Righteep;
    // Update is called once per frame
    void Update()
    {

        if (Gamepad.current.leftTrigger.wasPressedThisFrame)
        {
            LeftPeep.SetActive(true);
        }
        if (Gamepad.current.leftTrigger.wasReleasedThisFrame)
        {
            LeftPeep.SetActive(false);
        }
        if (Gamepad.current.rightTrigger.wasPressedThisFrame)
        {
            Righteep.SetActive(true);
        }
        if (Gamepad.current.rightTrigger.wasReleasedThisFrame)
        {
            Righteep.SetActive(false);
        }

    }
}
