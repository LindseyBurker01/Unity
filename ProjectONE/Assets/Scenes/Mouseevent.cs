using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Mouseevent : MonoBehaviour
{
    public UnityEvent mouseEvent;

    private void OnMouseDown()
    {
        mouseEvent.Invoke();
    }

}
