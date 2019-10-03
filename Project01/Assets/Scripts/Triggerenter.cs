using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using EventTrigger = UnityEngine.Analytics.EventTrigger;

public class Triggerenter : MonoBehaviour
{
    public ParticleSystem particle;
    public UnityEvent Event;
    private void OnTriggerEnter(Collider other)
    {
        particle.Emit(10);
        Event.Invoke();
    }
}
