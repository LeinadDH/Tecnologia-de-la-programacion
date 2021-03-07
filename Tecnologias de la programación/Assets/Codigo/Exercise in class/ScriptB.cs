using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptB : MonoBehaviour
{
    [SerializeField]
    private string name;
    private ScriptA scriptA;
    // Start is called before the first frame update
    void Start()
    {
        scriptA = FindObjectOfType<ScriptA>();
        scriptA.Function1(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
