
using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    private ID otherID;
    
    private void OnTriggerEnter(Collider other)
    {
        
    // Debug.Log(idObj);
    // Debug.Log(other.GetComponent<IdContainerBehaviour>().idObj);

        var temp0bj =  other.GetComponent<IdContainerBehaviour>();
        if (temp0bj != null) otherID = temp0bj.idObj;
        if(otherID == idObj)
        {
            Debug.Log("Matched");
        }

    }
}
