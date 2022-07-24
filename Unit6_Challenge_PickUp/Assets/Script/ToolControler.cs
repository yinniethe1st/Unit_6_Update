using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolControler : MonoBehaviour
{
   
   PlayerMovement2 playermov;
   Rigidbody2D rb;

   [SerializeField] float offsetDistance = 1f;
   [SerializeField] float pickupZone = 1.5f;

   private void Awake()
   {
    playermov = GetComponent<PlayerMovement2>();
    rb = GetComponent<Rigidbody2D>();
   }

   private void Update()
   {
    if (Input.GetMouseButtonDown(0))
    {
        UseTool();

    }
   }

   private void UseTool()

   {
    Vector2 pos = rb.position + playermov.lastPos * offsetDistance;
    Collider2D[] colliders = Physics2D.OverlapCircleAll(pos, pickupZone);

    foreach(Collider2D c in colliders)
    {
        Tool hit = c.GetComponent<Tool>();
        if(hit != null )
        {
            hit.Hit();
            break;
        }
    }
   }

}
