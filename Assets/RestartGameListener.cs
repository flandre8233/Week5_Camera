using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class RestartGameListener : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
