using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manageButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startScene(int scene)
    {
        moveCamera.speed = 8f;
        SceneManager.LoadScene(scene);
    }
}
