using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNumbers : MonoBehaviour
{
    public Text textOutput;
    public string buttonText;
    public string outputData;

    public void ClickOnButton(){
        textOutput.text += buttonText;
    }

}
