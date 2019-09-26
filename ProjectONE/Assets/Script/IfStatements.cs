using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    // This Code is all about If Statements
    
    //ints are complete numbers
    public int a = 5, b = 5, c = 10;
    //strings use characters
    public string password = "OU812";
    //Bools can only be true or false
    public bool lightsOn = false;
        
    void Start()
    {
        //If statements can only be used in functions. You can't place them wherever
        //If statements will only run when it is true.
        //EX. if a+b does equal c, it will execute the command in the brackets below. If not, it won't
        if (a+b == c)
        {
            print(true);
        }
        else
        {
            print(false);
        }
        
        if (password == "OU812")
        {
            print(true);
        }
        
        //The ! is asking if it's true that lightson is false
        //The long way would be: if (lightson == false)
        if (!lightsOn)
        {
            print(true);
        }
        
        // EX. string if (password != "friend")
        // EX. int if (a+b != c)

        
        //&& means both statements have to be true EX. if (this && that)
        //|| means or. It means one of the statements have to be true EX. if (this || that)


    }

}
