using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameActionScript : ScriptableObject
{
    public UnityAction action;

    public void Raise()
    {
        action?.Invoke();
    }
}

