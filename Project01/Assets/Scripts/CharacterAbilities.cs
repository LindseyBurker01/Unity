using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterAbilities : MonoBehaviour
{
    public UnityEvent trigger;
    
    //public void OnTriggerEnter(Collider other)
    //{
      //  trigger.Invoke();
    //}

    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            trigger.Invoke();
        }

    }
}
