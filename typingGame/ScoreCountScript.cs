using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCountScript : MonoBehaviour {

    public static int scoreValue = 0;
    Text scoreCounter;
    

	void Start () {
        scoreCounter = GetComponent<Text>();
	}

	void Update () {
        
        scoreCounter.text = "Score: " + scoreValue;       
	}
}
