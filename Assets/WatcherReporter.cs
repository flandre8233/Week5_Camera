using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class WatcherReporter : MonoBehaviour
{
    [SerializeField] Seeker Seeker;
    [SerializeField] PlayerExposure PlayerExposure;
    [SerializeField] HideText hidetext;
    bool FirstFrameSee = false;
    void Update()
    {
        Report();
    }

    void Report()
    {
        bool isSeeking = Seeker.IsSeeking();
        if (isSeeking)
        {
            PlayerExposure.ExposureAdd(Time.deltaTime * 50);
            hidetext.StartWarning();
            if (!FirstFrameSee)
            {
                FirstFrameSee = true;
                GlobalResourceSound.SpawnSound("Alert", transform.position);
            }
        }
        else
        {
            hidetext.EndWarning();
            if (FirstFrameSee)
            {
                FirstFrameSee = false;
            }
        }

    }

}
