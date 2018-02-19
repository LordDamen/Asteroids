using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollide : MonoBehaviour {

	/*
		When this object and an asteroid collide they destroy each other

		The bullet is also destroyed with the asteroid so that the screen does not fill with indestruble, all-powerful bullets
	*/

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	//Destroys both the bullet and the asteroid when they collide
	void OnCollisionEnter2D (Collision2D otherObject) {
		
		if (otherObject.gameObject.CompareTag ("Asteroid")) { //This will make sure that the bullet can destroy all of the different types of asteroids

			Destroy (otherObject.gameObject);
			Destroy (this.gameObject);
		}
	}
}
