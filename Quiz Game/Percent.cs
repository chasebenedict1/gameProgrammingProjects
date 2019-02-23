using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Percent : MonoBehaviour
{
    public static int percentValue = 0;
    Text percentText;

    void Start()
    {
        percentText = GetComponent<Text>();
    }

    void Update()
    {
        percentText.text = "Percent correct: " + percentValue + "%";
    }
}