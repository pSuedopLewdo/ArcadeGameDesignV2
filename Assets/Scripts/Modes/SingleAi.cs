using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleAi : MonoBehaviour
{
    public GameObject[] waypoints;
    public int waypointIndex;
    
    public float speed = 8;
    public float maxSpeed = 10;
    public float minDis = 0.1f;

    public GameObject p1Model;
    public Transform startPos;
    public GameObject playerOne;
    

    private void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        
        {
            p1Model = playerOne.GetComponent<PlayerOne>().Blueprint.model;
            GameObject.FindWithTag("PlayerOne");
            GameObject p1 =  Instantiate(playerOne, startPos);
            Instantiate(p1Model, p1.transform);
        }
    }

    public void DriveForward()
    {
        Vector3 waypointPosition = waypoints[waypointIndex].transform.position;
        MoveToPoint(waypointPosition);
        if (Vector3.Distance(transform.position, waypointPosition) < minDis)
            waypointIndex++;
        if (waypointIndex >= waypoints.Length) waypointIndex = 0;
    }
    
    public void MoveToPoint(Vector3 point)
    {
        var dirToPlayer = point - (Vector3) transform.position;

        if (dirToPlayer.magnitude > minDis)
        {
            dirToPlayer.Normalize();
            dirToPlayer *= speed * Time.deltaTime;
            transform.position += (Vector3) dirToPlayer;
        }
    }

    private void Update()
    {
        DriveForward();
    }
}
