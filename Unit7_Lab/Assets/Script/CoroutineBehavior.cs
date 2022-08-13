using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehavior : MonoBehaviour
{
    public bool canRun = true;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

        yield return wfsObj;
        Debug.Log("late start");
    

    while (canRun)
    {
    
        yield return wffuObj;
        Debug.Log("Run on start");
    }

    }
    
}

