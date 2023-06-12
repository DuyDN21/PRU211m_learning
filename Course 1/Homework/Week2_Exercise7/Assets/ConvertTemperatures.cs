using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Int();
        //Float();
        Double();
    }

    public void Int()
    {
        int originalF;
        int convertedC;
        int convertedF;

        originalF = 0;
        convertedC = (originalF - 32) / 9 * 5;
        convertedF = convertedC * 9 / 5 + 32;
        Debug.Log("Original F: " + originalF +
            "\nConverted C: " + convertedC +
            "\nConverted F: " + convertedF);
    }

    public void Float()
    {
        float originalF;
        float convertedC;
        float convertedF;

        originalF = 0;
        convertedC = (originalF - 32) / 9 * 5;
        convertedF = convertedC * 9 / 5 + 32;
        Debug.Log("Original F: " + originalF +
            "\nConverted C: " + convertedC +
            "\nConverted F: " + convertedF);
    }

    public void Double()
    {
        double originalF;
        double convertedC;
        double convertedF;

        originalF = 0;
        convertedC = (originalF - 32) / 9 * 5;
        convertedF = convertedC * 9 / 5 + 32;
        Debug.Log("Original F: " + originalF +
            "\nConverted C: " + convertedC +
            "\nConverted F: " + convertedF);
    }
}
