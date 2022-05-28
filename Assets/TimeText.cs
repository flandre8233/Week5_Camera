using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TimeText : MonoBehaviour
{
    [SerializeField]
    GameTimer gameTimer;
    [SerializeField] Text text;
    public void UpdateText(float Second)
    {
        TimeSpan time = TimeSpan.FromSeconds(Second);
        text.text = time.ToString("mm':'ss");
        text.color = Color.Lerp(Color.white,Color.red,  gameTimer.GetProgress());
    }
}
