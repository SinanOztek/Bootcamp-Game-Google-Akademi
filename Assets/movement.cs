using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool groundede;
    public float jumpHeight = 4f;
    void Update()

    {
        groundede = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (groundede && velocity.y < 0) 
        {

            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed* Time.deltaTime);
        if(Input.GetButtonDown("Jump") && groundede) 
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * speed *Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);

        
    }
}
