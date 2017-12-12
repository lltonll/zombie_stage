using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour {

	public int scoreValue = 10;
	public float health = 50.0f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void ReactToHit (float amount) {
		WanderingAI behavior = GetComponent<WanderingAI>();
		if (behavior != null) {
			behavior.SetAlive(false);
		}
		health -= amount;
		if (health <= 0f)
		{
			Die();
		}
	}

	void Die () {
		Destroy(gameObject);
		ScoreDisplay.score += scoreValue;
	}


}
