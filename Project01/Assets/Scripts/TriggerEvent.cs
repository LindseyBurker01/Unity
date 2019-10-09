using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using EventTrigger = UnityEngine.Analytics.EventTrigger;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent Event;
    public void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
    }
}
