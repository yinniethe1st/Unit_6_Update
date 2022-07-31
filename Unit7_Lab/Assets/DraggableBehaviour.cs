using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehaviour : MonoBehaviour
{

    // Start is called before the first frame update
    private Camera cameraObj;

    public bool draggable;
    public Vector3 position;

    
    void Start()
    {
        cameraObj = Camera.main;
    }


    public IEnumerator OnMouseDown()
    {

        draggable = true;
        while(draggable)
        {
            yield return new WaitForFixedUpdate();
            // Debug.Log("Drag");
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition);
            transform.position = position;
            
        }

    }

    private void OnMouseUp()
    {
        draggable = false;
    }
}
