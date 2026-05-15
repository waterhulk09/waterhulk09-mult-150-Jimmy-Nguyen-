using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationswitcher : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("Rotate");
           
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("Grow");
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("Float");

        }
        
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("Color");
        }
    }
}
