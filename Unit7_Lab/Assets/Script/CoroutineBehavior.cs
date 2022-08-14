using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    // public bool canRun = true;

    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, ReapeatUntilFalseEvent;

    public bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;


    private void Start()
    {
        startEvent.Invoke();

    }


    // Start is called before the first frame update
    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    private IEnumerator Counting()
    {
        
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startCountEvent.Invoke();
        yield return wfsObj;

    //     yield return wfsObj;
    //     Debug.Log("late start");
    

    
    while (counterNum.value > 0)
    {
        // Debug.Log(counterNum);
        yield return wfsObj;

        repeatCountEvent.Invoke();
        counterNum.value--;
      
    }
        endCountEvent.Invoke();

    }

    public void StartReapeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(ReapeatUntilFalse());
    }



    private IEnumerator ReapeatUntilFalse()
    {
        
    while (canRun)
    {
    
        yield return wfsObj;
        ReapeatUntilFalseEvent.Invoke();

    }

    }
    
}

