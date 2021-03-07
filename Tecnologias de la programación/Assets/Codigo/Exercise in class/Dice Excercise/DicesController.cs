using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicesController : MonoBehaviour
{
    Dice woodDice = new Dice(4, 4, "green", "wood");
    Dice redDice = new Dice(6, 8, "red", "plastic");
    Dice sixFaceDice = new Dice(6, 8, "blue", "plastic");
    Dice dice1 = new Dice();
    Dice dice6 = new Dice(6);

    CheatDicePair crookedDicePair = new CheatDicePair();
    CheatDiceOdd crookedDiceOdd = new CheatDiceOdd();
 



    // Start is called before the first frame update
    void Start()
    {
    
    Debug.Log("Color dado madera: " + woodDice.Color);
    woodDice.Color = "red";
    Debug.Log("Color dado madera: " + woodDice.Color);

    crookedDicePair.Greetings();
    crookedDicePair.helloDice();

    }

    // Update is called once per frame
    void Update()
    {
          
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
        crookedDiceOdd.InformationOddDice();
    }
}
