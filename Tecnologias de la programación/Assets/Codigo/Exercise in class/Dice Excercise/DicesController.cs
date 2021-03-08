using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicesController : MonoBehaviour
{
    Dice woodDice = new Dice(6, 8, "green", "wood");

    CheatDicePair crookedDicePair = new CheatDicePair("pair dice");
    CheatDiceOdd crookedDiceOdd = new CheatDiceOdd("odd dice");

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El numero de caras del dado es: " + woodDice.NumberOfFaces);
        Debug.Log("El numero de aristas del dado es: " + woodDice.NumberOfEdges);
        Debug.Log("El color del dado es : " + woodDice.Color);
        Debug.Log("El material del dado es : " + woodDice.Material);
    }

    public void RollPairDice()
    {
        crookedDicePair.reRollPair();
    }

    public void RollOddDice()
    {
        crookedDiceOdd.reRollOdd();
    }

    public void InformationOddDice()
    {
        Debug.Log("Usted solicito la informacion de: " + crookedDiceOdd.TypeOfDice);
        crookedDiceOdd.informationOddDice();
    }

    public void InformationPairDice()
    {
        Debug.Log("Usted solicito la informacion de: " + crookedDicePair.TypeOfDice);
        crookedDicePair.informationPairDice();
    }
}
