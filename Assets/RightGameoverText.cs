using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RightGameoverText : MonoBehaviour
{
    [SerializeField] Text text;
    public void SetUp(bool IsWin)
    {
        gameObject.SetActive(true);
        text.text = IsWin ? "Good Watcher!" : "You're Fired. ";
    }
}
