using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {
	// [SerializeField] private string loadlevel;
	// Use this for initialization

	void Start(){
		
	}
	void Update(){
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		if(ScoreDisplay.score >= 500 && currentIndex == 1){
			
			SceneManager.LoadScene (currentIndex + 1);
		}
		else if(ScoreDisplay.score >= 1000 && currentIndex == 3){

			SceneManager.LoadScene (currentIndex + 2);
		}
	}
	void OnTriggerEnter(Collider other) {
		
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;

		if (other.CompareTag("Enemy")) {
			SceneManager.LoadScene (4);
		}

	}
}
