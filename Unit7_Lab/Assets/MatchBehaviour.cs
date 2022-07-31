
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    // private ID otherID;
    public UnityEvent matchEvent, noMatchEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        
    // Debug.Log(idObj);
    // Debug.Log(other.GetComponent<IdContainerBehaviour>().idObj);

        var temp0bj =  other.GetComponent<IdContainerBehaviour>();
        // if (temp0bj != null) otherID = temp0bj.idObj;

        if (temp0bj == null)
            return;

        var otherID = temp0bj.idObj;

        if(otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else 
        {
            noMatchEvent.Invoke();
        }

    }
}
