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

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = idObj as ColorID;
        renderer.color = newColor.value;
        
    }

}
