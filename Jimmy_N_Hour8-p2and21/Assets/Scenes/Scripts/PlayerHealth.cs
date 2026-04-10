using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
// Start is called before the first frame update
{ 
    
    int healthpoints = 3992;
    
    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        Debug.Log("health added: " + healthpoints);
        
        healthpoints = UsePotion(healthpoints);
        Debug.Log("health added again: " + healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}
