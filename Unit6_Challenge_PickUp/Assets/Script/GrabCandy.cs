using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabCandy : MonoBehaviour

{

    public Transform GrabACandy;
    public Transform CandyHolder;
    public float Grab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit2D grabCheck = Physics2D.Raycast(GrabACandy.position, Vector2.right * transform.localScale, Grab);

        if(grabCheck.collider != null && grabCheck.collider.tag == "Candy")
        {
            if(Input.GetKey(KeyCode.G))
            {
                grabCheck.collider.gameObject.transform.parent = CandyHolder;
                grabCheck.collider.gameObject.transform.position = CandyHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody>().isKinematic = true;

            } else 
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        
    }
}
