using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements.StyleEnums;

public class TriggerPowerup : MonoBehaviour
{
    public float speed = 5f;
    private void OnTriggerEnter(Collider other)
    {
        speed = increasespeed(5f);
        throw new NotImplementedException();
    }

    private float increasespeed(float multiplier)
    {
        return speed = multiplier;
    }
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
