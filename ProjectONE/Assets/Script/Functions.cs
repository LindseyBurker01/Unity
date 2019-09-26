using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public string playerName;
    private int myNumber;

    public float speed = 5f;
    public GameObject player;
    public Color playerColor = Color.red;
    void Start()
    {
        configGameObject();
    }

    private GameObject configGameObject()
    {
        var newPlayer = Instantiate(player);
        newPlayer.layer = 0;
        newPlayer.active = true;
        newPlayer.tag = "Player";
        newPlayer.transform.position = Vector3.zero;
        newPlayer.name = playerName;
        newPlayer.GetComponent<Renderer>().material.color = playerColor;
        return player;
    }
    
    // Every time you hit the thing, you go 2X faster
    private void OnTriggerEnter(Collider other)
    {
        speed = increaseSpeed(2f);
    }

    //because it isn't a void, it needs to return something or else it'll error
    private float increaseSpeed(float multiplier)
    {
        return speed * multiplier;
    }

    private string welcomePlayer()
    {
        return playerName + " Welcome to the Game!!";
    }
    
    private int addNumbers(int a, int b)
    {
        print(a + b);
        return a + b;
    }
    
    
}
