using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFireWeapon : MonoBehaviour
{
    public float holdTime = 1f;
    public WaitForSeconds WaitForSeconds;
    private bool canRun = true;
    public GameActionScript gameActionObj;

    private void Awake()
    {
        WaitForSeconds = new WaitForSeconds(holdTime);
    }

    private IEnumerator OnMouseDown()
    {
        canRun = true;
        while (canRun)
        {
            gameActionObj.Raise();
            yield return WaitForSeconds;
        }
    }
    private void OnMouseUp()
    {
        canRun = false;
    }
}
