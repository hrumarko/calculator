using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionEnum : MonoBehaviour
{
    public double Division(double firstNum, double secondNum){
        return firstNum/secondNum;
    }

    public double Sum(double firstNum, double secondNum){
        return firstNum+secondNum;
    }
    public double Minus(double firstNum, double secondNum){
        return firstNum-secondNum;
    }
    public double Multiplication(double firstNum, double secondNum){
        return firstNum*secondNum;
    }

}
