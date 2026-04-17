using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float moveSpeed = 5.0f;
   
        
        // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        //print(other.gameObject.name + " You have entered");
    }
    
    void OnTriggerExit(Collider other)
    {
        //print(other.gameObject.name + " You have left");
    }
}
