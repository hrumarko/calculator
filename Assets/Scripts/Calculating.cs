using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculating : MonoBehaviour
{
    public Text resultText;
    public Text inputDataText;
    ActionEnum act = new ActionEnum();
    

    public void ClickButtonToResult(){
        string a = inputDataText.text;
        int index=0;
        string firstNum = "";
        string secondNum = "";
        
        char[] aArray = a.ToCharArray();                                                       
        for(int i = 0; i < aArray.Length; i++){
            if(aArray[i]!= '/' && aArray[i]!= '*' && aArray[i]!= '+' && aArray[i]!= '-'){
               firstNum += aArray[i]; 
            }
            else{
                index = i;
                break;
            }
        }
        double firstnum = Convert.ToDouble(firstNum);
        
        char actionChar = aArray[index];
        
        for(int i = index+1;i <aArray.Length; i++){
            secondNum += aArray[i];
        }
        double secondnum = Convert.ToDouble(secondNum);

        if(actionChar == '/'){
            double result = act.Division(firstnum, secondnum);
            resultText.text = result.ToString();
        }

        if(actionChar == '*'){
            double result = act.Multiplication(firstnum, secondnum);
            resultText.text = result.ToString();
        }

        if(actionChar == '+'){
            double result = act.Sum(firstnum, secondnum);
            resultText.text = result.ToString();
        }

        if(actionChar == '-'){
            double result = act.Minus(firstnum, secondnum);
            resultText.text = result.ToString();
        }
    }

}
