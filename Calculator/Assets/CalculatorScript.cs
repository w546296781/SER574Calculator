using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CalculatorDll;

public class CalculatorScript : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public InputField result;
    private CalculatorClass cc = new CalculatorClass();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add()
    {
        result.text = cc.Add(System.Convert.ToDouble(input1.text), System.Convert.ToDouble(input2.text)).ToString();
    }

    public void Sub()
    {
        result.text = cc.Substract(System.Convert.ToDouble(input1.text), System.Convert.ToDouble(input2.text)).ToString();
    }

    public void Mul()
    {
        result.text = cc.multiply(System.Convert.ToDouble(input1.text), System.Convert.ToDouble(input2.text)).ToString();
    }

    public void Div()
    {
        result.text = cc.divide(System.Convert.ToDouble(input1.text), System.Convert.ToDouble(input2.text)).ToString();
    }
}
