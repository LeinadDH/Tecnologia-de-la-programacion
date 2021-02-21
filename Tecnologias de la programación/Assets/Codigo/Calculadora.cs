using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Calculadora : MonoBehaviour
{
    [SerializeField]
    Text Input;

    string InputString;
    double[] number = new double[2];
    string operatorSymbol;
    int i = 0;
    double resultado;
    bool DisplayResultado = false;

    public void Buttons()
    {

        if (DisplayResultado == true)
        {
            Input.text = "";
            InputString = "";
            DisplayResultado = false;
        }

        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;

        InputString += buttonValue;

        double Arg;

        if (double.TryParse(buttonValue, out Arg))
        {
                if (i > 1) i = 0;
                number[i] = Arg;
                i = i + 1;
        }

        else
        {
            switch(buttonValue)
            {
                case "+":
                    operatorSymbol = buttonValue;
                    break;
                case "-":
                    operatorSymbol = buttonValue;
                    break;
                case "x":
                    operatorSymbol = buttonValue;
                    break;
                case "/":
                    operatorSymbol = buttonValue;
                    break;

                case "=":
                   switch(operatorSymbol)
                   {
                        case "+":
                            resultado = number[0] + number[1];
                            break;
                        case "-":
                            resultado = number[0] - number[1];
                            break;
                        case "x":
                            resultado = number[0] * number[1];
                            break;
                        case "/":
                            resultado = number[0] / number[1];
                            break;
                   }

                    DisplayResultado = true;
                    InputString = resultado.ToString();
                    number = new double[2];
                    break;

            }

        }

        Input.text = InputString;

    }
}
