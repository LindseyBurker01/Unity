using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Forces : MonoBehaviour
{
    // This Code gives a RigidBody physics, aka bouncy boi
    private Rigidbody rb;
    public Vector3 forces;

    void Start()
    {
        // In order to use GetComponet, you need [RequireComponent] above
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(forces);
        // Another way is rb.AddForce(0,0,0); but the previous way makes it so you can manually add it in unity
    }
}
