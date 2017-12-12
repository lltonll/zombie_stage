using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour {
	public int score;
	// Use this for initialization
	void Start () {
		ScoreCount oldCount = FindObjectOfType<ScoreCount> ();
		score = 0;
		if (oldCount) {
			score = oldCount.score;
			Destroy (oldCount.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
