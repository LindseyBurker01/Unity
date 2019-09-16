using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerClickEvent : MonoBehaviour
{

    public UnityEvent mouseClick;
    public void OnMouseDown(Collider other)
    {
        mouseClick.Invoke();
    }
}
