using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerPlayer : MonoBehaviour
{
   public static GameManagerPlayer instance;

   private void Awake()
   {
    instance = this;
   }

   public GameObject player;
}
