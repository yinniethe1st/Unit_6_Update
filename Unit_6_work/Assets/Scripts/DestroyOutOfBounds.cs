using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBounds = 30.0f;

    public float loweBounds = -20.0f;

     
  
    void Awake()
    {
       Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds )
        {
            Destroy(gameObject);
        }   

        else if(transform.position.z < loweBounds)
        {
            Debug.Log("Game OVer!");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
