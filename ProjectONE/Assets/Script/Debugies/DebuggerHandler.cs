using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggerHandler : MonoBehaviour
{

    public Debugger debuggerObj;

    public void switchDebugger(Debugger newDebuggerObj)
    {
        debuggerObj = newDebuggerObj;
    }

    void Update()
    {
        debuggerObj.OnDebug();
    }
}
