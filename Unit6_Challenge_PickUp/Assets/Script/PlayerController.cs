using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizonalInput;

    public float speed = 50;

    public float xRange = 40;

    public Transform blaster;

    public GameObject lazerBolt;

    public GameManager gameManager;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Reference GameManager script on GameManager Object
    }
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

        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            // Create lazerBolt at the blaster transform position maintaining object position
            Instantiate(lazerBolt, blaster.position, lazerBolt.transform.rotation);
        }



    }

    private void OntriggerEnter(Collider collision)
    {
        Debug.Log("Colliding");
    }


}
