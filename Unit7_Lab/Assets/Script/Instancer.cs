using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
  
public GameObject prefab;
private int num;

  public void CreateInstance(GameObject obj)
  {

    Instantiate(prefab);

  }

  public void CreateInstance (Vector3Data obj)

  {
    Instantiate(prefab, obj.value, Quaternion.identity);
  }

  public void CreateInstanceFromList(VectorDataList obj)
  {

        foreach (var t in obj.vector3DList)
        { 
        Instantiate(prefab, t.value, Quaternion.identity);
        }
  }



   public void CreateInstanceFromListCounting(VectorDataList obj)
  {
    Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
    num ++;  
        if (num == obj.vector3DList.Count)
        {
            num = 0;
        }
    
  }


}
