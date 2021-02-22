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
    string temp = "";
    double Arg;
    double temp1, temp2;

    public void Buttons()
    {

        if (DisplayResultado == true)
        {
            Input.text = "";
            InputString = "";
            DisplayResultado = false;
        }

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;

        InputString += buttonValue;



        if (double.TryParse(buttonValue, out Arg))
        {
            
            temp = temp + buttonValue;
            Debug.Log(buttonValue);
            Debug.Log(temp);

        }
        
        else
        {
            switch(buttonValue)
            {
                case "+":
                    operatorSymbol = buttonValue;
                    double.TryParse(temp, out temp1);
                    number[0] = temp1;
                    temp = "";
                    break;
                case "-":
                    operatorSymbol = buttonValue;
                    double.TryParse(temp, out temp1);
                    number[0] = temp1;
                    temp = "";
                    break;
                case "x":
                    operatorSymbol = buttonValue;
                    double.TryParse(temp, out temp1);
                    number[0] = temp1;
                    temp = "";
                    break;
                case "/":
                    operatorSymbol = buttonValue;
                    double.TryParse(temp, out temp1);
                    number[0] = temp1;
                    temp = "";
                    break;

                case "=":
                   switch(operatorSymbol)
                   {
                        case "+":
                            double.TryParse(temp, out temp2);
                            number[1] = temp2;
                            resultado = number[0] + number[1];
                            break;
                        case "-":
                            double.TryParse(temp, out temp2);
                            number[1] = temp2;
                            resultado = number[0] - number[1];
                            break;
                        case "x":
                            double.TryParse(temp, out temp2);
                            number[1] = temp2;
                            resultado = number[0] * number[1];
                            break;
                        case "/":
                            double.TryParse(temp, out temp2);
                            number[1] = temp2;
                            resultado = number[0] / number[1];
                            break;
                   }

                    DisplayResultado = true;
                    InputString = resultado.ToString();
                    break;

            }

        }

        Input.text = InputString;

    }
}
