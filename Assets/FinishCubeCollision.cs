using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCubeCollision : MonoBehaviour
{
    [SerializeField] GameObject PlayerObject;
    [SerializeField] PlayerInv Inv;
    [SerializeField] WarningText WarningText;

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerNear())
        {
            Inv.GetTreasure();
            WarningText.StartWarning();
            gameObject.SetActive(false);
        }
    }

    bool IsPlayerNear()
    {
        return Vector3.Distance(transform.position, PlayerObject.transform.position) <= 2;
    }
}
