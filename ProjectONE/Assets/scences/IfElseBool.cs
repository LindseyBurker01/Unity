using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseBool : MonoBehaviour
{

    public bool appleIsRipe, orangeIsRipe, peachIsRipe;
    
    void Start()
    {
        //This code sucks because the computer looks at each else if statement, whether its true or not
        if (appleIsRipe)
        {
            print("Go Pick the Apple.");
        }
        else if (orangeIsRipe)
        {
            print("Go Pick the Orange.");
        }
        else if (peachIsRipe)
        {
            print("Go Pick the Peach.");
        }
        else
        {
            print("Go Pick on your Sibling.");
        }
        
        
        
    }

}
