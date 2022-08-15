using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IdContainerBehaviour
{
    public ColorIdDataList ColorIdDataListObj;

    private void Awake()
    {
        idObj = ColorIdDataListObj.currentColor;
    }

}
