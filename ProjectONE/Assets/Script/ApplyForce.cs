using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ApplyForce : MonoBehaviour
{
<<<<<<< HEAD
    private Rigidbody rb; 
    public Vector3Data forceDirection; 
    public float force = 3f; 
     
    private void Start() 
    { 
        rb = GetComponent<Rigidbody>(); 
        rb.AddForce(forceDirection.value * force);
    }
=======
    public Rigidbody rb;
    public Vector3data forceDirection;
    public float force = 3f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(forceDirection.value * force);
        Instantiate(rb);
    }
    
>>>>>>> master
}
