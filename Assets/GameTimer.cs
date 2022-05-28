using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameTimer : MonoBehaviour
{
    [SerializeField] GameResultJudge judge;
    [SerializeField] TimeText timeText;
    [SerializeField] float TotalSeconds;
    float CurrentSeconds;

    private void Start()
    {
        CurrentSeconds = TotalSeconds;
    }

    private void Update()
    {
        CurrentSeconds = Mathf.Clamp(CurrentSeconds - Time.deltaTime, 0, TotalSeconds);
        timeText.UpdateText(CurrentSeconds);

        if (IsTimeEnd())
        {
            judge.RunnerLose();
        }
    }

    bool IsTimeEnd()
    {
        return CurrentSeconds <= 0;
    }

    public float GetProgress()
    {
        return Mathf.Abs(1 - (CurrentSeconds / TotalSeconds));
    }

}
