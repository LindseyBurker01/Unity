using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Function : MonoBehaviour
{
    public string playername = "Tester";

    public GameObject player;
    public Color playerColor = Color.blue;
    void Start()
    {
        configgameobject();
    }

    private GameObject configgameobject()
    {
        var newplayer = player;
        newplayer.layer = 0;
        newplayer.tag = "Player";
        newplayer.name = playername;
        newplayer.GetComponent<Renderer>().material.color = playerColor;
        return player;
    }

}
