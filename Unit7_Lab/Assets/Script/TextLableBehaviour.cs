// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Events;

// using UnityEngine.UI;
// using System.Globalization;

// [RequireComponent(typeof(Text))]


// public class TextLableBehaviour : MonoBehaviour
// {

//     private Text label;
//     // public FloatData dataObj;

//     public UnityEvent startEvent;


//     private void Start()
//     {
//         label = GetComponent<Text>();
//        // UpdateLabel();
//         startEvent.Invoke();
        
//     }

//     //   public void UpdateLabel()
//     // {
//     //     label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);

//     // }


//     public void UpdateLabel(FloatData obj)
//     {
//         label.text = obj.value.ToString(CultureInfo.InvariantCulture);
//     }

   

//     public void UpdateLabel(IntData obj)
//     {
//         label.text = obj.value.ToString(CultureInfo.InvariantCulture);

//     }
// }
