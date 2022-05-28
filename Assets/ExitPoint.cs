using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPoint : MonoBehaviour
{
    [SerializeField] GameObject PlayerObject;
    [SerializeField] GameResultJudge Judge;
    [SerializeField] PlayerInv Inv;

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerNear() && Inv.IsGot())
        {
            Judge.RunnerWin();
            enabled = false;
        }
    }

    bool IsPlayerNear()
    {
        return Vector3.Distance(transform.position, PlayerObject.transform.position) <= 4;
    }
}
