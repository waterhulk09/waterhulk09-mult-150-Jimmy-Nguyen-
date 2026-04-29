using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    
        void Start()
  
    
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPosition = new Vector3(i * 10.0f, 0, 0) + transform.position;

            Instantiate(prefab, spawnPosition, transform.rotation);
        }
    }


    // Update is called once per frame

    

    void Update()
    {

 if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position,transform.rotation);

        }
    }
}