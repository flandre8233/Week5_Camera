using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{
    bool IsGetTreasure;
    public bool IsGot()
    {
        return IsGetTreasure;
    }
    public void GetTreasure()
    {
        IsGetTreasure = true;
    }
}
