using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 22;
        Debug.Log(number);

        while (number < 100)
        {
            number += 2;
            Debug.Log(number);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
