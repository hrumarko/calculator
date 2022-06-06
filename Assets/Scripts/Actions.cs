using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions : MonoBehaviour
{
    public Text outputData;
    public string actionText;
    

    public void InputAction(){
        
        outputData.text += actionText;

    }
}
