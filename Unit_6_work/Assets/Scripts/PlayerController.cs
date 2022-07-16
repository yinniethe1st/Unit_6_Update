using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed =25;

   public float xRange = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // Set HorizontalInput to recieve values from keyboard

        horizontalInput = Input.GetAxis("Horizontal");

    // Moves Player left and right
        transform.Translate( Vector3.right * horizontalInput * Time.deltaTime * speed );

    // Keep player with in bounds
    // Left side wall
        if(transform.position.x < -xRange ) 
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
    // Right side wall
        if(transform.position.x > xRange ) 
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
        
    }
}
