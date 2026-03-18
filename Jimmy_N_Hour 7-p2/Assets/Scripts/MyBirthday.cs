using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 31; i++)
        {
            if (i == 17)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}