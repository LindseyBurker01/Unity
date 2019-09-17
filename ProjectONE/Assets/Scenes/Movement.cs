using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float gravity = 3f;
    public float jumpspeed = 100f;

    private int jumpcount = 2;
    
    private Vector3 position;
    public CharacterController controller;
    void Update()
    {
        position.x = speed*10*Input.GetAxis("Horizontal");
        
        if (!controller.isGrounded )
        {
            
            position.y -= gravity;
        }
        else
        {
            jumpcount = 2;
        }
        
        if (Input.GetButton("Jump") && jumpcount > 0)
        {
            jumpcount--;
            position.y = jumpspeed;
        }
        
        controller.Move(position*Time.deltaTime);
    }
}
