
using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    // private ID otherID;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    
    private IEnumerator  OnTriggerEnter(Collider other)
    {
        
    // Debug.Log(idObj);
    // Debug.Log(other.GetComponent<IdContainerBehaviour>().idObj);

        var temp0bj =  other.GetComponent<IdContainerBehaviour>();
        // if (temp0bj != null) otherID = temp0bj.idObj;

        if (temp0bj == null)
            yield break;

        var otherID = temp0bj.idObj;

        if(otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else 
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }

    }
}
