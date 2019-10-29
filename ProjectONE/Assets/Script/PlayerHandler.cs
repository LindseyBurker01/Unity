using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerHandler : ScriptableObject
{
    public Playerdata playerDataObj;

    public void SwitchPlayer(Playerdata data)
    {
        playerDataObj = data;
    }
    void OnRun()
    {
        //playerDataObj.Run();
    }
}
