using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
   void OntriggerEnter(Collider other)
   {
    
    Destroy(gameObject); // Destroy this gameobject
    Destroy(other.gameObject); // Destroy other gameObject

   }
}
