using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ScriptableObjects need an asset to work, so CreateAssetMenu
[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value = 1;

    public void UpdateValue(int numb)
    {
        value += numb;
    }
}
