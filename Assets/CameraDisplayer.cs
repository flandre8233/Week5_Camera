using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDisplayer : MonoBehaviour
{
    [SerializeField] RightCameraSwitcher Switcher;
    public void FollowByCurrentCamera()
    {
        Vector3 NewPosition = Switcher.GetCurrentCamera().transform.position;
        transform.position = new Vector3(NewPosition.x, 10, NewPosition.z);
    }
}
