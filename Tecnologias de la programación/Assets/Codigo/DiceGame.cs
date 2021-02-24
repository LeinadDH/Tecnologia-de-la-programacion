using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceGame : MonoBehaviour
{
    private int Dice1;
    private int Dice2;
    private int Dice3;

    public void RollDice()
    {
        Dice1 = Random.Range(1, 6);
        Dice2 = Random.Range(1, 6);
        Dice3 = Random.Range(1, 6);

        if (Dice1 == Dice2 && Dice1 == Dice3)
        {
            Debug.Log("ganaste");
        }

        if (Dice1 != Dice2 || Dice1 != Dice3)
        {
            Debug.Log("perdiste");
        }
    }
}
