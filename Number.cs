using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Number : MonoBehaviour
{
    public static int numberValue = 0;
    Text numberText;

    void Start()
    {
        numberText = GetComponent<Text>();
    }

    void Update()
    {
        numberText.text = "Question number: " + numberValue;
    }
}