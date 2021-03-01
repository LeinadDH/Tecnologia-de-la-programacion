using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceGame : MonoBehaviour
{
    private int dice1;
    private int dice2;
    private int dice3;

    public void RollDice()
    {
        dice1 = Random.Range(1, 7);
        dice2 = Random.Range(1, 7);
        dice3 = Random.Range(1, 7);

        if ((dice1 == dice2) && (dice1 == dice3))
        {
            Debug.Log("ganaste");
        }

        if ((dice1 != dice2) || (dice1 != dice3))
        {
            Debug.Log("perdiste");
        }
    }
}
