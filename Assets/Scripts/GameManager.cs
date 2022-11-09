using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        MainMenu,
        PvP,
        PvAi,
        PumpkinRun,
    }

    public static GameState gameState;

    private void Update()
    {
        States();
    }

    public void States()
    {
        switch (gameState)
        {
            case GameState.MainMenu:
                StartCoroutine(MainMenu());
                break;
            case GameState.PvP:
                StartCoroutine(PvP());
                break;
            case GameState.PvAi:
                StartCoroutine(PvAi());
                break;
            case GameState.PumpkinRun:
                StartCoroutine(PumpkinRun());
                break;
        }
    }

    private static IEnumerator MainMenu()
    {
        Debug.Log("MainMenu");
       
        gameState = GameState.MainMenu;
        yield return null;

    }

    private static IEnumerator PvP()
    {
        Debug.Log("PvP");
        gameState = GameState.PvP;
        yield return null;

    }

    private static IEnumerator PvAi()
    {
        Debug.Log("PvAi");

        gameState = GameState.PvAi;
        yield return null;


    }

    private static IEnumerator PumpkinRun()
    {
        Debug.Log("PumpkinRun");
        gameState = GameState.PumpkinRun;
        yield return null;
    }
}
