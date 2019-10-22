using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class TriggerEvent : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    public UnityEvent Event;
    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
    }
    
}
