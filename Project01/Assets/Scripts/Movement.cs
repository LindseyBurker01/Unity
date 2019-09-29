using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;
    public float moveSpeed = 10f, gravity = 3f, jumpSpeed = 50f;

    private int jumpCount, jumpCountMax = 1;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.y -= gravity;

        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }

        controller.Move(position * Time.deltaTime);
        //controller.minMoveDistance = 0;
    }
    
}
