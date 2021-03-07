using UnityEngine;
public class CheatDicePair : Dice{

    private int rollResultPair = 1;

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

}