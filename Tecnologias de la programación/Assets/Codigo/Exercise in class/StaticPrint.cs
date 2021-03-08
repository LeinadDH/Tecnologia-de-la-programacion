using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticPrint : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El resultado de la sumas es: " + Calculation.Sum(6, 7));

        Debug.Log("El resultado de la resta es: " + Calculation.Substraction(8, 2));
    }

}
