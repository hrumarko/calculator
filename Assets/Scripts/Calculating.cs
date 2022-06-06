using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculating : MonoBehaviour
{
    public Text resultText;
    public Text inputDataText;
    AlgorythmAction act = new AlgorythmAction();
    [HideInInspector] public double firstnum;
    [HideInInspector] public double secondnum;

    
    // ActionEnum act;
    
    

    public void ClickButtonToResult(){  
        string a = inputDataText.text;               //разбитие строки на символы
        char[] aArray = a.ToCharArray();             //в массив
        List<char> left = new List<char>();        //списки для будущих чисел //до знака
        List<char> right = new List<char>();                                  //после знака
        int index=0;                    //индекс знака в массиве символов
        if(a == ""){                                   // ошибка при отстутствии даннных
            resultText.text = "Error";
            return;

        }
        
        for(int i = 0; i < aArray.Length; i++){                                                //цикл идет до знака
            if(aArray[i]!= '/' && aArray[i]!= '*' && aArray[i]!= '+' && aArray[i]!= '-'){      //записывая символы в             
               left.Add(aArray[i]);                                                            //массив left
            }                                                                                  //остановка на знаке
            else{                                                                              //и запись его индекса
                index = i;                                                               //в ранее созданую переменную
                break;
            }
        }

        for(int i = index+1; i< aArray.Length; i++){         //второе число(после знака)
            right.Add(aArray[i]); 
        }

        string leftStr = new string(left.ToArray());               //перевод массива в строку
        double firstnum = double.Parse(leftStr);                   //из массива в число типа double
        string rightStr = new string(right.ToArray());
        double secondnum = double.Parse(rightStr);

        char actionChar = aArray[index];                        //знак действия
        
        
        
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
