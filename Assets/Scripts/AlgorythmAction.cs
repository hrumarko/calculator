using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlgorythmAction : MonoBehaviour                            //класс с стратегиями
{

    public double Division(double firstNum, double secondNum){                   //деление
        return firstNum/secondNum;
    }

    public double Sum(double firstNum, double secondNum){                         // сумма
        return firstNum+secondNum;
    }
    public double Minus(double firstNum, double secondNum){                      //отнимание
        return firstNum-secondNum;
    }
    public double Multiplication(double firstNum, double secondNum){                      //умножение
        return firstNum*secondNum;
    }

}
