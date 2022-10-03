using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boolcharintfloatstring : MonoBehaviour
{
    public string MyName = "Mine";
    private string YourName = "Yours";

    public int MyNumber = 0;
    private int YourNumber = 1;

    public bool MyBool = false;
    private bool YourBool = true;

    public char MyChar = 'M';
    private char YourChar = 'Y';

    public float MyFloat = 0.1f;
    private float YourFloat = 0.2f;

    public double MyDouble = 0.1;
    private double YourDouble = 0.2;

    void Start()
    {
        //MyName是string所以可以直接與string相加
        Debug.Log("MyName is: " + MyName);

        //MyNumber是integer所以必須先把他轉成String才能相加
        Debug.Log("YourNumber is: " + MyNumber.ToString());
    }
    void Update()
    {
        
    }

}
