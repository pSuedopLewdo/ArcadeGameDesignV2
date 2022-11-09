using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScreen : MonoBehaviour
{
    public CarBluePrint[] carBluePrint;
    public int offRoadIndex;
    public int raceCarIndex;

    public bool playerOneChosen;
    public bool playerTwoChosen;
    
    public GameObject playerOne;
    public GameObject playerTwo;

    public PlayerOne p1Script;
    public PlayerTwo p2Script;
    
    public Canvas singlePlayerCanvas;
    public Canvas multiPlayerCanvas;

    public void Start()
    {
        if (GameManager.gameState == GameManager.GameState.PumpkinRun || GameManager.gameState == GameManager.GameState.PvAi)
        {
            multiPlayerCanvas.gameObject.SetActive(false);
            singlePlayerCanvas.gameObject.SetActive(true);
        }
        else if (GameManager.gameState == GameManager.GameState.PvP)
        {
            multiPlayerCanvas.gameObject.SetActive(true);
            singlePlayerCanvas.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("No game state");
        }

        p1Script = playerOne.GetComponent<PlayerOne>();
        p2Script = playerTwo.GetComponent<PlayerTwo>();
    }

    public void BackButton()
    {
        GameManager.gameState = GameManager.GameState.MainMenu;
        SceneManager.LoadScene(0);
    }

    public void PlayerOneOffRoad()
    {
        p1Script.Blueprint = carBluePrint[offRoadIndex];
        Debug.Log(p1Script.Blueprint);
        playerOneChosen = true;
    }

    public void PlayerTwoOffRoad()
    {
        p2Script.Blueprint = carBluePrint[offRoadIndex];
        Debug.Log(p2Script.Blueprint);

        playerTwoChosen = true;
    }

    public void PlayerOneRaceCar()
    {
        p1Script.Blueprint = carBluePrint[raceCarIndex];
        Debug.Log(p1Script.Blueprint);

        playerOneChosen = true;
    }

    public void PlayerTwoRaceCar()
    {
        p2Script.Blueprint = carBluePrint[raceCarIndex];
        Debug.Log(p2Script.Blueprint);

        playerTwoChosen = true;
    }

    private void PvP()
    {
        if (playerOneChosen && playerTwoChosen)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            return;
        }
    }

    private void PvAi()
    {
        if (playerOneChosen)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            return;
        }
    }

    private void PumpkinRun()
    {
        if (playerOneChosen)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            return;
        }
    }

    public void Update()
    {
        if (GameManager.gameState == GameManager.GameState.PumpkinRun)
        {
            PumpkinRun();
        }
        else if (GameManager.gameState == GameManager.GameState.PvP)
        {
            PvP();
        }
        else if (GameManager.gameState == GameManager.GameState.PvAi)
        {
            PvAi();
        }
        else
        {
            return;
        }

    }
}
