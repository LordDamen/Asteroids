using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {

	/*
		Creates a projectile at the player's position
	*/

	public GameObject projectile;

	private Transform playerTf;

	// Use this for initialization
	void Start () {
		
		playerTf = GameManager.gm.player.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (GameManager.gm.gameIsStarted == true) {
			
			if (Input.GetKeyDown (KeyCode.Space)) {
				Instantiate (projectile, playerTf.position, playerTf.rotation);
			}
		}
	}
}
