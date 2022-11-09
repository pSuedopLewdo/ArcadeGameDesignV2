using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinPickup : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.CompareTag("Pumpkin"))
        {
            Debug.Log("Pumpkin");
            SinglePumpkinRun.score += SinglePumpkinRun.pumpkinScore;
            Destroy(collision.gameObject);           
        }
        else if (collision.transform.gameObject.CompareTag("Corn"))
        {
            Debug.Log("Corn");
            SinglePumpkinRun.score += SinglePumpkinRun.pumpkinScore;
            Destroy(collision.gameObject);
        }
        else if (collision.transform.gameObject.CompareTag("BadPumpkin"))
        {
            Debug.Log("BadPumpkin");
            SinglePumpkinRun.score += SinglePumpkinRun.pumpkinScore;
            Destroy(collision.gameObject);
        }
        else if (collision.transform.gameObject.CompareTag("BadCorn"))
        {
            Debug.Log("BadCorn");
            SinglePumpkinRun.score += SinglePumpkinRun.pumpkinScore;
            Destroy(collision.gameObject);
        }
    }
}
