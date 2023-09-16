using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    
    void Start()
    {
        // Mendeklarasikan Variable
        int variableInteger;
        float variableFloat;
        double variableDouble;
        bool variableBoolean;
        char variableCharracter;
        string variableString;

        //Mengisikan nilai ke dalam variable
        variableInteger = 10;
        variableFloat = 2.5f;
        variableDouble = 7.5;
        variableBoolean = true;
        variableCharracter = 'S';
        variableString = "Ini adalah String";

        //Memunculkan nilai variable ke dalam console
        Debug.Log("Variable Integer : " + variableInteger);
        Debug.Log("Variable Float : " + variableFloat);
        Debug.Log("Variable Double : " + variableDouble);
        Debug.Log("Variable Boolean : " + variableBoolean);
        Debug.Log("Variable Character : " + variableCharracter);
        Debug.Log("Variable String : " + variableString);


    }

    // Update is called once per frame
    
}
