using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Light Lightbulb;
    void Start()
    {
        Lightbulb = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Lightbulb.enabled = !Lightbulb.enabled;

        }
            
    }
}
