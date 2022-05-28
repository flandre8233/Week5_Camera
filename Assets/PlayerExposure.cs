using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExposure : MonoBehaviour
{
    [SerializeField] public float Exposure;
    [SerializeField] GameResultJudge Judge;
    [SerializeField] Healthbar bar;

    private void Update()
    {
        ExposureAdd(-(Time.deltaTime * 5));
    }

    public void ExposureAdd(float Val)
    {
        Exposure = Mathf.Clamp(Exposure + Val, 0, 100);
        bar.SetHealth(Exposure);
        if (IsMax())
        {
            Judge.RunnerLose();
        }
    }

    bool IsMax()
    {
        return Exposure >= 100;
    }
}
