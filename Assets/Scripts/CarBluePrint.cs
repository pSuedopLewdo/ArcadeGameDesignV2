using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "carBluePrint", menuName = "CarBluePrint")]
public class CarBluePrint : ScriptableObject
{
    public new string name;
    public string description;
    
    public float speed;
    public float grassSpeed;

    public GameObject model;
}
