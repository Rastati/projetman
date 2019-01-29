using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenutest : MonoBehaviour {

    public string LoadLevel;

    public void StartGame() {

        Application.LoadLevel  (LoadLevel);
    }

    // Update is called once per frame
    public void quitGame() {

        Application.Quit();
    }
}
