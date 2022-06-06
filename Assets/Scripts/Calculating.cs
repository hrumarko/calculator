using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculating : MonoBehaviour
{ 
    public Text resultText;                    //результат
    public Text inputDataText;                   //входящие данные
    AlgorythmAction act = new AlgorythmAction();
    

    public void ClickButtonToResult(){  
                      
        char[] aArray = inputDataText.text.ToCharArray();            //разбитие строки на символыв массив
        List<char> left = new List<char>();                          //списки для будущих чисел //до знака
        List<char> right = new List<char>();                                                    //после знака
        int index=0;                    //индекс знака в массиве символов
        if(inputDataText.text == "" || inputDataText.text.Contains(",,")){                                   // ошибка при отстутствии даннных
            resultText.text = "Error";
            return;
        }
        
        for(int i = 0; i < aArray.Length; i++){                                                //цикл идет до знака
            if(aArray[i]!= '/' && aArray[i]!= '*' && aArray[i]!= '+' && aArray[i]!= '-'){      //записывая символы в             
               left.Add(aArray[i]);                                                            //массив left
            }else{                                                                              //и запись его индекса
                index = i;                                                                      //в ранее созданую переменную
                break;
            }                                                                                  //остановка на знаке
        }

        for(int i = index+1; i< aArray.Length; i++){         //второе число(после знака)
            right.Add(aArray[i]); 
        }

        string leftStr = new string(left.ToArray());               //перевод массива в строку                          
        string rightStr = new string(right.ToArray());

        if(leftStr == "" || leftStr.Contains(",,") || leftStr.StartsWith(",") || rightStr == "" || rightStr.StartsWith(",")||rightStr.Contains(",,")){
            resultText.text = "Error";
            return;
        }

        double secondnum = double.Parse(rightStr);          //из строки в число типа double
        double firstnum = double.Parse(leftStr);
        char actionChar = aArray[index];                     //знак действия
        resultText.text = DoAction(actionChar, firstnum, secondnum);   
    }
    
    public string DoAction(char actionChar, double firstnum, double secondnum){            //метод выполняющий действия с двумя числами
        double result = 0;                                                                 // в зависимости от знака
        if(actionChar == '/'){
            result = act.Division(firstnum, secondnum);
            
        }

        if(actionChar == '*'){
            result = act.Multiplication(firstnum, secondnum);
            
        }

        if(actionChar == '+'){
            result = act.Sum(firstnum, secondnum);
            
        }

        if(actionChar == '-'){
            result = act.Minus(firstnum, secondnum);
            
        }
        string str = result.ToString();
        return str;


    }

    

}
