using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameActionScript gameActionObj;
    public UnityEvent handlerEvent;
    
    void Start()
    {
        gameActionObj.action = RaiseHandler;
    }

    public void RaiseHandler()
    {
        handlerEvent.Invoke();
    }

}
