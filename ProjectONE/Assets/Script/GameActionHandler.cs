<<<<<<< HEAD
﻿using UnityEngine;
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
>>>>>>> master
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
<<<<<<< HEAD
    public GameActionScript gameActionObj;
    public UnityEvent handlerEvent;
    
=======
    public GameAction gameActionObj;
    public UnityEvent handlerEvent;
>>>>>>> master
    void Start()
    {
        gameActionObj.action = RaiseHandler;
    }

    public void RaiseHandler()
    {
        handlerEvent.Invoke();
    }
<<<<<<< HEAD

=======
>>>>>>> master
}
