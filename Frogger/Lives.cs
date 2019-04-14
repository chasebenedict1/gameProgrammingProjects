using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{

    public static int CurrentLives = 3;

    public Text livesText;

    void Start()
    {
        livesText.text = CurrentLives.ToString();
    }

}
