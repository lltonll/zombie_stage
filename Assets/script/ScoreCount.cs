using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour {
	public int score = 0;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}

	// Update is called once per frame
	void Update () {

	}
	public void IncreseScore(int amount){
		score += amount;
		print ("Score : " + score);
	}

}
