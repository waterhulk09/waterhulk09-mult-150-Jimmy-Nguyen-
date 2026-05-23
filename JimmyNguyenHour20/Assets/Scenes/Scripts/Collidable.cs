using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float moveSpeed = 20f;
    public float timeAmount = 1.5f;

    void Start()
    {
        if (manager == null)
        {
            manager = FindObjectOfType<GameManager>();
        }
    }

    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (manager != null)
            {
                manager.AdjustTime(timeAmount);
            }

            Destroy(gameObject);
        }
    }
}