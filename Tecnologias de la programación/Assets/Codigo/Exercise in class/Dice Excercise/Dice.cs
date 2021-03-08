using UnityEngine;

public class Dice{

    // Atributes
    private int numberOfFaces;
    private int numberOfEdges;
    private string color;
    private string material;

    // Constructors
    public Dice(int anumberOfFaces, int anumberOfEdges, string acolor, string amaterial)
    {
        numberOfFaces = anumberOfFaces;
        numberOfEdges = anumberOfEdges;
        color = acolor;
        material = amaterial;
    }

    public Dice()
    {

    }

    public Dice(int anumberOfFaces)
    {
        numberOfFaces = anumberOfFaces;
    }

    // Methods
    public void helloDice(){
        Debug.Log("Hola desde la clase dice");
    }


    // Getters Setters Properties
    public string Color
    {
        get { return color; }
        set 
        { 
            if(value == "green" || value == "red" || value == "blue")
            {
                color = value;    
            }
            else
            {
                color = "NA";
            }             
        }
    }

    public int NumberOfFaces
    {
        get { return numberOfFaces; }
        set
        {
            if(value == 10 || value == 6)
            {
                numberOfFaces = value;
            }
            else
            {
                numberOfFaces = 0;
            }
        }
    }

    public int NumberOfEdges
    {
        get { return numberOfEdges; }
        set
        {
            if (value == 20 || value == 8)
            {
                numberOfEdges = value;
            }
            else
            {
                numberOfEdges = 0;
            }
        }
    }

    public string Material
    {
        get { return material; }
        set
        {
            if (value == "plastic" || value == "wood" || value == "glass")
            {
                material = value;
            }
            else
            {
                material = "NA";
            }
        }
    }


}

