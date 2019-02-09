using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {
    public void sceneTransitionButtonClick(string sceneName)
    {
        Application.LoadLevel("Main");

    }

}
