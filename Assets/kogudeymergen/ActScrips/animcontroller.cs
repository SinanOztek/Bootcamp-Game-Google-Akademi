using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcontroller : MonoBehaviour
{


    Animator animator;

    
    
    
    void Start() 
    {

        animator = GetComponent<Animator>();
    
    }
    
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("isRuning", true);
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("isRuning", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
            {
            animator.SetBool("fasterRun", true);
        }

        if (!Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("fasterRun", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJump", true);
        }

        if (!Input.GetKey(KeyCode.Space)) 
        {
            animator.SetBool("isJump", false);
        }
    }
}
