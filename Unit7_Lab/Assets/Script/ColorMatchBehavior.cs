using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehavior : MatchBehaviour
{
      public ColorIdDataList ColorIdDataListObj;

    private void Awake()
    {
        idObj = ColorIdDataListObj.currentColor;
    }

}
