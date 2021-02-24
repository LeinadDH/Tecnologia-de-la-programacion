using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Calculation
{
    //used for sum
    static int number1 = 5;
    static int number2 = 4;

    //used for substraction
    static int number3 = 8;
    static int number4 = 10;

    static void Sum(int result1)
    {
       result1 = number1 + number2;
       Debug.Log(result1);
    }

    static void Substraction(int result2)
    {
       result2 = number3 - number4;
       Debug.Log(result2);
    }

}
