using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Debugger : ScriptableObject
{
    public void Debug(string label)
    {
        UnityEngine.Debug.Log(label);
    }

    public void OnDebug()
    {
        UnityEngine.Debug.Log(name);
    }
}
