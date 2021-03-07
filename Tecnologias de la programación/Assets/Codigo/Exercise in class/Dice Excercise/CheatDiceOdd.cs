using UnityEngine;
public class CheatDiceOdd : Dice
{

    private int rollResultOdd = 1;

    Dice oddDice = new Dice(10, 10, "blue", "plastic");

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

    public void InformationOddDice()
    {
        Debug.Log("El color del dado cargado (Impar) es: " + oddDice.Color);
    }

}
