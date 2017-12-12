using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {
	public Transform player;
	public float minSpeed = 15.0f;
	public float maxSpeed = 20.0f;
	public float velo = 10.0f;
	NavMeshAgent nav;

	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;

		nav = GetComponent <NavMeshAgent> ();
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		nav.SetDestination (player.position);
		nav.speed = Random.Range(minSpeed, maxSpeed);
		nav.acceleration = Random.Range(velo, velo + 5);
	}
}
