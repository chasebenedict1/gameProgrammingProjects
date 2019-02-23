using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour {

    private static string[] wordList = { "threshold", "straw", "trunk", "van", "angle", "heir", "health", "seasonal", "bloodshed", "sheep", "order", "elephant" };

    
    public static string GetRandomWord ()
    {

        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}
