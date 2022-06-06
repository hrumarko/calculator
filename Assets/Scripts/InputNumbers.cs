using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNumbers : MonoBehaviour
{
    public Text textOutput;        //куда вводить текст
    public Text resultText;          //результат
    public string buttonText;
    

    public void ClickOnButton(){                            //ввод данных
        textOutput.text += buttonText;
    }

    public void RemoveSymbol(){                        //очистить все
        textOutput.text = "";
        resultText.text = "";
    }

    public void RemoveLastSymbol(){                                //очистить последний символ
        if(textOutput.text.Length > 1){                                                 
            textOutput.text = textOutput.text.Remove(textOutput.text.Length);         
        } else{
            RemoveSymbol();
        }
         
    }

}
