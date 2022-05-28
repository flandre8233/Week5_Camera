using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class StartGameListener : MonoBehaviour
{
    [SerializeField] UIStatus UIStatus;
    [SerializeField] GameObject PlayerCell;
    void Update()
    {
        if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {
            StartGame();
        }
    }

    void StartGame()
    {
        UIStatus.ToGame();
        PlayerCell.SetActive(false);
    }
}
