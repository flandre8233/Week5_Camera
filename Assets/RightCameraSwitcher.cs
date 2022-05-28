using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class RightCameraSwitcher : MonoBehaviour
{
    [SerializeField] GameObject[] RightCameras;
    [SerializeField] CameraText CameraText;
    [SerializeField] CameraDisplayer CameraDisplayer;
    int CurrentCameraIndex;

    private void Start()
    {
        Invoke("DelayStart", 0.1f);
    }

    // Start is called before the first frame update
    void DelayStart()
    {
        SetAllCameraClose();
        PreOpenCurrentCamera();
        OpenCurrentCamera();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            CancelInvoke();
            SetCurrentCameraClose();
            ChangeCameraCh(false);
            PreOpenCurrentCamera();
            Invoke("OpenCurrentCamera", 1.1f);
        }

        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            CancelInvoke();
            SetCurrentCameraClose();
            ChangeCameraCh(true);
            PreOpenCurrentCamera();
            Invoke("OpenCurrentCamera", 1.1f);
        }

    }

    void SetAllCameraClose()
    {
        foreach (GameObject item in RightCameras)
        {
            item.GetComponent<Camera>().enabled = false;
            item.GetComponent<AudioListener>().enabled = false;
            item.GetComponent<CameraRotate>().enabled = false;
            item.GetComponent<WatcherCameraControll>().CloseCamera();
        }
    }

    void SetCurrentCameraClose()
    {
        RightCameras[CurrentCameraIndex].GetComponent<Camera>().enabled = false;
        RightCameras[CurrentCameraIndex].GetComponent<AudioListener>().enabled = false;
        RightCameras[CurrentCameraIndex].GetComponent<CameraRotate>().enabled = false;
        RightCameras[CurrentCameraIndex].GetComponent<WatcherCameraControll>().CloseCamera();
    }

    void ChangeCameraCh(bool IsUP)
    {
        CurrentCameraIndex += IsUP ? +1 : -1;
        CurrentCameraIndex = (int)Mathf.Repeat(CurrentCameraIndex, RightCameras.Length);
        GlobalResourceSound.SpawnSound("WhiteNoise", transform.position);

    }

    void PreOpenCurrentCamera()
    {
        RightCameras[CurrentCameraIndex].GetComponent<WatcherCameraControll>().ActivingCamera();
        RightCameras[CurrentCameraIndex].GetComponent<AudioListener>().enabled = true;
        CameraText.TextUpdateLoading();
        CameraDisplayer.FollowByCurrentCamera();
    }

    void OpenCurrentCamera()
    {
        RightCameras[CurrentCameraIndex].GetComponent<Camera>().enabled = true;

        RightCameras[CurrentCameraIndex].GetComponent<WatcherCameraControll>().ActiveCamera();
        RightCameras[CurrentCameraIndex].GetComponent<CameraRotate>().enabled = true;
        CameraText.TextUpdate();
    }

    public Camera GetCurrentCamera()
    {
        return RightCameras[CurrentCameraIndex].GetComponent<Camera>();
    }

    public string GetCurrentCameraName()
    {
        return GetCurrentCamera().gameObject.name;
    }
}
