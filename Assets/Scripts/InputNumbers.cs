using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNumbers : MonoBehaviour
{
    public Text textOutput;
    public Text resultText;
    public string buttonText;
    public string outputData;

    public void ClickOnButton(){
        textOutput.text += buttonText;
    }

    public void RemoveSymbol(){
        textOutput.text = "";
        resultText.text = "";
    }

    public void RemoveLastSymbol(){
        if(textOutput.text.Length > 1){
        textOutput.text = textOutput.text.Remove(1);
        } else{
            RemoveSymbol();
        }
    }

}
