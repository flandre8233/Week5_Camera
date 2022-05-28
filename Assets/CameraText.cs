using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraText : MonoBehaviour
{
    [SerializeField] RightCameraSwitcher Switcher;
    [SerializeField] Text text;
    public void TextUpdate()
    {
        text.text = Switcher.GetCurrentCameraName();
    }
    public void TextUpdateLoading()
    {
        text.text = "Connect to " + Switcher.GetCurrentCameraName() + "...";
    }
}
