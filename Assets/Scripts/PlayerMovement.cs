using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerOne _playerOne;
    private PlayerTwo _playerTwo;
    
    private static float speed;
    private void Update()
    {
        if (CompareTag("PlayerOne"))
        {
            GetComponent<PlayerOne>();
            PlayerOneMovement();
        }
        else if (CompareTag("PlayerTwo"))
        {
            GetComponent<PlayerTwo>();
            PlayerTwoMovement();
        }
    }
    void PlayerOneMovement()
    {
        speed = GetComponent<PlayerOne>().speed;
        var xAxis = Input.GetAxis("P1 Horizontal");
        var zAxis = Input.GetAxis("P1 Vertical");
        var move = new Vector3(xAxis, 0, zAxis);

        move.Normalize();
        move *= speed * Time.deltaTime;

        
        
        Quaternion targetRotation = Quaternion.LookRotation(move);
        targetRotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            360 * Time.fixedDeltaTime);
        
        transform.position += move;
        transform.rotation = targetRotation;

    }

    void PlayerTwoMovement()
    {
        speed = GetComponent<PlayerTwo>().speed;
        var xAxis = Input.GetAxis("P2 Horizontal");
        var zAxis = Input.GetAxis("P2 Vertical");
        var move = new Vector3(xAxis,0 , zAxis);

        move.Normalize();
        move *= speed * Time.deltaTime;
        
        
        Quaternion targetRotation = Quaternion.LookRotation(move);
        targetRotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            360 * Time.fixedDeltaTime);
        
        transform.position += move;
        transform.rotation = targetRotation;
        
        
    }
}
