using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PVP : MonoBehaviour
{
    public Transform first;
    public Transform second;
    
    public GameObject playerOne;
    public GameObject playerTwo;

    public GameObject p1Model;
    public GameObject p2Model;
    
    public Quaternion rotation = Quaternion.Normalize(new Quaternion());
    
    // Start is called before the first frame update
    void Start()
    {
        p1Model = playerOne.GetComponent<PlayerOne>().Blueprint.model;
        p2Model = playerTwo.GetComponent<PlayerTwo>().Blueprint.model;
        GameObject.FindWithTag("PlayerOne");
        GameObject.FindWithTag("PlayerTwo");    
        GameObject p1 =  Instantiate(playerOne, first);
        GameObject p2 = Instantiate(playerTwo, second);
        Instantiate(p1Model, p1.transform);
        Instantiate(p2Model, p2.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
