using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    // public bool canRun = true;

    public UnityEvent repeatEvent;

    public int counterNum = 3;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

    //     yield return wfsObj;
    //     Debug.Log("late start");
    

    // while (canRun)
    // {
    
    //     yield return wfsObj;
    //     Debug.Log("Run on start");
    // }
    while (counterNum > 0)
    {
        yield return wfsObj;
        repeatEvent.Invoke();
        counterNum--;
        Debug.Log(counterNum);
    }


    }
    
}

