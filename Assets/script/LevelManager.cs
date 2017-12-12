using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			LoadNextScene ();
		}
	}
	public void LoadNextScene(){
		// Gettting Index of Active Scene

		int CurrentIndex = SceneManager.GetActiveScene ().buildIndex;
		if (CurrentIndex + 1 == SceneManager.sceneCountInBuildSettings || CurrentIndex + 2 == SceneManager.sceneCountInBuildSettings) {
			SceneManager.LoadScene (0);
		} else {
			SceneManager.LoadScene (CurrentIndex + 1);
		}
		// Load next scene

	}


}
