using UnityEngine;
public class CheatDicePair : Dice{

    private int rollResultPair = 1;
    private string typeOfDice;

    Dice pairDice = new Dice(10, 20, "red", "glass");

    public CheatDicePair(string atypeOfDice)
    {
        typeOfDice = atypeOfDice;
    }

    public void Greetings()
    {
        Debug.Log("Hola, soy un dado cargado");
    }

    public void reRollPair(){

        if (rollResultPair == 1 || rollResultPair == 3 || rollResultPair == 5 || rollResultPair == 7 || rollResultPair == 9)
        {
            rollResultPair = Random.Range(1, 11);
            reRollPair();
        }

        else if (rollResultPair == 2 || rollResultPair == 4 || rollResultPair == 6 || rollResultPair == 8 || rollResultPair == 10)
        {
            Debug.Log("El resultado del dado cargado (par) es: " + rollResultPair);
            rollResultPair = Random.Range(1, 11);
        }

    }

    public void informationPairDice()
    {
        Debug.Log("El numero de caras del dado cargado (Par) es: " + pairDice.NumberOfFaces);
        Debug.Log("El numero de vertices del dado cargado (Par) es: " + pairDice.NumberOfEdges);
        Debug.Log("El color del dado cargado (Par) es: " + pairDice.Color);
        Debug.Log("El material del dado cargado (Par) es: " + pairDice.Material);
    }

    public string TypeOfDice
    {
        get { return typeOfDice; }
        set
        {
            if (value == "pair dice")
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