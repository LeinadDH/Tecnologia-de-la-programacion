using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Calculation
{
    static int number1 = 10;
    static int number2 = 3;

    public static int Sum (int numberOne, int numberTwo)
    {
        int result;
        result = numberOne + numberTwo;
        return result;
    }

    public static int Substraction(int numberOne, int numberTwo)
    {
        int result;
        result = numberOne - numberTwo;
        return result;
    }
}
