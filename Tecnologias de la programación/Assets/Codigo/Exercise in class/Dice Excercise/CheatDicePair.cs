using UnityEngine;
public class CheatDicePair : Dice{

    public int rollResult = 1;

    public void Greetings()
    {
        Debug.Log("Hola, soy un dado cargado");
    }

    public void reRoll(){

        if (rollResult == 1 || rollResult == 3 || rollResult == 5 || rollResult == 7 || rollResult == 9)
        {
            rollResult = Random.Range(1, 11);
        }

        if (rollResult == 2 || rollResult == 4 || rollResult == 6 || rollResult == 8 || rollResult == 10)
        {
            Debug.Log("El resultado del dado cargado par es: " + rollResult);
            rollResult = Random.Range(1, 11);
        }

    }


}