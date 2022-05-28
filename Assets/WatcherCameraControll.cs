using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatcherCameraControll : MonoBehaviour
{
    [SerializeField] Renderer CameraView;
    [SerializeField] float OrlXAngle;
    float OffAngle;
    FloatLerp AngleLerp;

    private void Start()
    {
        OrlXAngle = transform.eulerAngles.x;
        OffAngle = 90f;
        AngleLerp = new FloatLerp();
    }

    public void ActivingCamera()
    {
        AngleLerp = new FloatLerp();
        AngleLerp.startLerp(OffAngle, OrlXAngle, 1f);
    }
    public void ActiveCamera()
    {
        CameraView.material.color = Color.red;
    }
    public void CloseCamera()
    {
        CameraView.material.color = Color.black;
        AngleLerp = new FloatLerp();
        AngleLerp.startLerp(OrlXAngle, OffAngle, 1f);
    }

    private void Update()
    {
        if (AngleLerp.isLerping)
        {
            transform.rotation = Quaternion.Euler(AngleLerp.update(), transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }
}
