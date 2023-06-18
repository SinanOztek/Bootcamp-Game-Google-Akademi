using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdfly : MonoBehaviour
{
    [SerializeField] public float speed, levitationSpeed;

    public CharacterController controller;
    public Vector3 moveDirection;

    private void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    private void Update () 
    {
        Move();

        Fly();
    }

    private void Fly() 
    {
        moveDirection = Vector3.up * levitationSpeed * Time.deltaTime;

        if(Input.GetKey(KeyCode.Space))
            controller.Move(moveDirection);
        else if (Input.GetKey(KeyCode.LeftShift))
            controller.Move(-moveDirection);
    }

    private void Move() 
    { 
        float horizontalInput= Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalInput= Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 move = transform.forward * verticalInput + transform.right * horizontalInput;
        controller.Move(move);
    }
    
}
