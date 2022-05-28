using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LeftGameoverText : MonoBehaviour
{
    [SerializeField] Text text;
    public void SetUp(bool IsWin)
    {
        gameObject.SetActive(true);
        text.text = IsWin ? "Pro Action!!" : "Busted. ";
    }
}
