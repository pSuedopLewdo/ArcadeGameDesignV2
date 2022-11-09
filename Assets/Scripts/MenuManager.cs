using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Canvas main;
    public Canvas mode;

    private void Start()
    {
        mode.gameObject.SetActive(false);
    }

    public void PlayButton()
    {
        if (main.gameObject == isActiveAndEnabled)
        {
            main.gameObject.SetActive(false);
            mode.gameObject.SetActive(true);
        }
        else
        {
            return;
        }
    }
    public void BackButton()
    {
        if (mode.gameObject == isActiveAndEnabled)
        {
            mode.gameObject.SetActive(false);
            main.gameObject.SetActive(true);
        }
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void PvPButton()
    {
        GameManager.gameState = GameManager.GameState.PvP;
        SceneManager.LoadScene(1);
        
    }
    public void PvAiButton()
    {
        GameManager.gameState = GameManager.GameState.PvAi;
        SceneManager.LoadScene(1);
    }
    public void PumpkinRunButton()
    {
        GameManager.gameState = GameManager.GameState.PumpkinRun;
        SceneManager.LoadScene(1);
    }
}