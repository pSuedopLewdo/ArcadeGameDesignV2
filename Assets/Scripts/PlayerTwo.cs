using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    public CarBluePrint Blueprint;

    public new string name;
    public string desc;
    public float speed;
    public float grassSpeed;
    public GameObject model;

    private void Start()
    {
        speed = Blueprint.speed;
        grassSpeed = Blueprint.grassSpeed;
        model = Blueprint.model;
        name = Blueprint.name;
        desc = Blueprint.description;
    }
}
