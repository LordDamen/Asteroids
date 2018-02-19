using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	/*
		Player class that holds the number of lives and is used to reference the main player object
	*/

	public int lives;

	// Use this for initialization
	void Start () {
		
		lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
