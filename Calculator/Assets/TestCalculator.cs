using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CalculatorDll;

public class TestCalculator : MonoBehaviour
{
    public double addA;
    public double addB;
    public double addResult;

    // Start is called before the first frame update
    void Start()
    {
        CalculatorClass testdll = new CalculatorClass();
        Debug.Log(testdll.divide(3, 7));
        addResult = testdll.Add(addA, addB);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
