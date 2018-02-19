using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollide : MonoBehaviour {

	/*
		Sets the player object to not active when this object collides with them
	*/


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//When an asteroid collides with the player object the player object is "killed"
	void OnCollisionEnter2D (Collision2D otherObject) {
		
		if (otherObject.gameObject.CompareTag ("Player")) {
			otherObject.gameObject.SetActive (false);
		}
	}
}
