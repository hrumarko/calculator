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
    
    // ActionEnum act;
    
    

    public void ClickButtonToResult(){
        
        string a = inputDataText.text;
        
        int index=0;
        
        
        char[] aArray = a.ToCharArray();
        List<char> left = new List<char>();
        List<char> right = new List<char>();

                                                           
        for(int i = 0; i < aArray.Length; i++){
            if(aArray[i]!= '/' && aArray[i]!= '*' && aArray[i]!= '+' && aArray[i]!= '-'){
               
               left.Add(aArray[i]); 
            }
            else{
                index = i;
                break;
            }
        }

        for(int i = index+1; i< aArray.Length; i++){
            right.Add(aArray[i]); 
        }
        string leftStr = new string(left.ToArray());
        double firstnum = double.Parse(leftStr);
        string rightStr = new string(right.ToArray());
        double secondnum = double.Parse(rightStr);
        
        

       

        
        
        
        char actionChar = aArray[index];
        
        // for(int i = index+1;i <aArray.Length; i++){
        //     secondNum += aArray[i].ToString();
           
        // }
        // double secondnum = Convert.ToDouble(secondNum);
        // Debug.Log(secondNum);
        // Debug.Log(firstNum);
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
