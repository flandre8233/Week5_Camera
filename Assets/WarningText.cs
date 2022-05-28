using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningText : MonoBehaviour
{
    public void StartWarning()
    {
        gameObject.SetActive(true);
        Invoke("Start", 5f);
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }
}
