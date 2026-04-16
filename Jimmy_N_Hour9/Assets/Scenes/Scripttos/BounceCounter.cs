using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int bounceCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        bounceCounter++;
        print(other.gameObject.name + " Bounced. Total Bounces: " + bounceCounter);
    }
   }
