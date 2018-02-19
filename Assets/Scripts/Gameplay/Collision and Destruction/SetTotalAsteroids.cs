using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTotalAsteroids : MonoBehaviour {

	/*
		Substracts from the variable representing the total number of big asteroids when they are destroyed so that more can be spawned
	*/

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy () {
		
		GameManager.gm.totalBigAsteroids--;
	}
}
