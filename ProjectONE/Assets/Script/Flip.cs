using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
<<<<<<< HEAD
    public Vector3Data data; 
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        { 
            transform.rotation = Quaternion.Euler(0, 180,0); 
            data.value.x = -1; 
        } 
 
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        { 
            transform.rotation = Quaternion.Euler(0, 0,0); 
            data.value.x = 1f; 
        } 
    } 
=======
    public Vector3data data;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180,0);
            data.value.x = -1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0,0);
            data.value.x = 1f;
        }
    }
>>>>>>> master
}
