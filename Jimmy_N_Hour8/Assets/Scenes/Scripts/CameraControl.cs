using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Camera cameraComponent;
   
    // Start is called before the first frame update
    void Start()
    {
        cameraComponent = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
           
        transform.Translate(mxVal * 0.1f, myVal * 0.1f, 0f);
            

    }
}
