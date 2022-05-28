using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideText : MonoBehaviour
{
    public void StartWarning()
    {
        gameObject.SetActive(true);
    }

    public void EndWarning()
    {
        gameObject.SetActive(false);
    }
}
