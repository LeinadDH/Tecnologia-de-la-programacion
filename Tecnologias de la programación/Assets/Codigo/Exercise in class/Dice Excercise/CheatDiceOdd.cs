using UnityEngine;
public class CheatDiceOdd : Dice
{

    private int rollResultOdd = 1;
    private string typeOfDice;

    Dice oddDice = new Dice(10, 20, "blue", "plastic");

    public CheatDiceOdd(string atypeOfDice)
    {
        typeOfDice = atypeOfDice;
    }

    public void Greetings()
    {
        Debug.Log("Hola, soy un dado cargado");
    }

    public void reRollOdd()
    {

        if (rollResultOdd == 1 || rollResultOdd == 3 || rollResultOdd == 5 || rollResultOdd == 7 || rollResultOdd == 9)
        {
            Debug.Log("El resultado del dado cargado (impar) es: " + rollResultOdd);
            rollResultOdd = Random.Range(1, 11);
        }

        else if (rollResultOdd == 2 || rollResultOdd == 4 || rollResultOdd == 6 || rollResultOdd == 8 || rollResultOdd == 10)
        {
            rollResultOdd = Random.Range(1, 11);
            reRollOdd();
        }

    }

    public void informationOddDice()
    {
        Debug.Log("El numero de caras del dado cargado (Impar) es: " + oddDice.NumberOfFaces);
        Debug.Log("El numero de vertices del dado cargado (Impar) es: " + oddDice.NumberOfEdges);
        Debug.Log("El color del dado cargado (Impar) es: " + oddDice.Color);
        Debug.Log("El material del dado cargado (Impar) es: " + oddDice.Material);
    }

    public string TypeOfDice
    {
        get { return typeOfDice; }
        set
        {
            if (value == "odd dice")
            {
                typeOfDice = value;
            }
            else
            {
                typeOfDice = "NA";
            }
        }
    }

}
