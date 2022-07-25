using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 330.0f;
    public float lowerBounds = 100.0f;

  
    void Awake()
    {
        // Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds )
        {
            Destroy(gameObject);
        }
        else if(transform.position.z > lowerBounds)
        {
            // Debug.Log("Game Over!");
            Destroy(gameObject);

        }
    }
}