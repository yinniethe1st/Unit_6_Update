using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    // public bool canRun = true;

    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, ReapeatUntilFalseEvent;

    // public bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    public bool canRun
    {
        get => canRun;
        set => canRun = value;
    }
    private void Start()
    {
        startEvent.Invoke();

    }


    // Start is called before the first frame update
    public void StartCounting()
    {
         wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        StartCoroutine(Counting());
    }
    
    private IEnumerator Counting()
    {
        
       
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

