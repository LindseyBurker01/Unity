using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CodeRoutines : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float sec = 10f;
    private int counter = 10;
    private WaitForSeconds wfsObj;

    private void Awake()
    {
        wfsObj = new WaitForSeconds(sec);
    }

    public void CallCoroutine()
    {
        StartCoroutine(RunCoroutine());
    }

    IEnumerator RunCoroutine()
    {
        startEvent.Invoke();
        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return wfsObj;
            counter--;
        }
        endEvent.Invoke();
    }
}
