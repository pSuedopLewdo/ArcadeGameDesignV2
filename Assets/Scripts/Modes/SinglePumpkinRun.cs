using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SinglePumpkinRun : MonoBehaviour
{
    public GameObject[] objects;
    public int spawnCount;
    
    public static int score;
    public static int highScore;
    public static int pumpkinScore;
    public static int cornScore;
    
    public Text scoreText;
    public Text timerText;

    public GameObject pickupHolder;
    public Transform first;
    public GameObject playerOne;

    public Camera cam;

    public float timer;
    public bool timerOn;

    public GameObject p1Model;

    //randomly generated objects that the player will be allowed to pick up to increase the score

    private void Start()
    {
        RandomlySpawnPumpkins();
        p1Model = playerOne.GetComponent<PlayerOne>().Blueprint.model;
        GameObject.FindWithTag("PlayerOne");
        GameObject p1 =  Instantiate(playerOne, first);
        Instantiate(p1Model, p1.transform);
        
        cam.transform.SetParent(p1.transform);

    }

    private void RandomlySpawnPumpkins()
    {
        foreach (var pickup in objects)
        {
            for (int i = 0; i < spawnCount; i++)
            {
                int randomX = Random.Range(-80, 80);
                int randomZ = Random.Range(-50, 50);
                Vector3 spawnPos = new Vector3(randomX, 0, randomZ);
                Instantiate(pickup, spawnPos, Quaternion.identity, pickupHolder.transform);
            }
        }        
    }

    private void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
