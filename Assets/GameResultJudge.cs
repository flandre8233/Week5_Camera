using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResultJudge : MonoBehaviour
{
    [SerializeField] UIStatus uIStatus;
    [SerializeField] LeftGameoverText LeftGameoverText;
    [SerializeField] RightGameoverText RightGameoverText;


    void WatcherWin()
    {
        RightGameoverText.SetUp(true);
    }
    void WatcherLose()
    {
        RightGameoverText.SetUp(false);
    }

    public void RunnerWin()
    {
        uIStatus.ToResult();
        LeftGameoverText.SetUp(true);
        WatcherLose();
    }

    public void RunnerLose()
    {
        uIStatus.ToResult();
        LeftGameoverText.SetUp(false);
        WatcherWin();
    }

}
