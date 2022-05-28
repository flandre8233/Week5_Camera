using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [SerializeField] GameObject Title;
    [SerializeField] GameObject Game;
    [SerializeField] GameObject Result;

    private void Start()
    {
        ToTitle();
    }

    public void ToTitle()
    {
        CloseAll();
        Title.SetActive(true);
    }

    public void ToGame()
    {
        CloseAll();
        Game.SetActive(true);
    }

    public void ToResult()
    {
        CloseAll();
        Result.SetActive(true);
    }

    public void CloseAll()
    {
        Title.SetActive(false);
        Game.SetActive(false);
        Result.SetActive(false);
    }

}
