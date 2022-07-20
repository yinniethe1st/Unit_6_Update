using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizonalInput;

    public float speed = 50;

    public float xRange = 40;


    // Update is called once per frame
    void Update()
    {

        // Set HorizontalInput to recieve values from keyboard
        horizonalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right

        transform.Translate(Vector3.right * horizonalInput * Time.deltaTime * speed);
        // Keep player in bound
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Right side wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }



    }
}
