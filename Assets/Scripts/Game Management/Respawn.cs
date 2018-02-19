using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	/*
		Respawns the player at the center of the screen

		Clears all of the remaining interactable objects off the screen

		Removes one life counter when the player respawns
	*/

	private Transform playerTf;
	private Vector3 origin;
	private Quaternion initialAngle;
	private GameObject[] objsToClear;

	// Use this for initialization
	void Start () {
		
		playerTf = GameManager.gm.player.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Happens only when the player dies
		if (GameManager.gm.player.gameObject.activeInHierarchy == false) {

			//Finds all objects in the game and clears all of the active objects (bullets and asteroids)
			objsToClear = FindObjectsOfType<GameObject> ();
			for (int i = 0; i < objsToClear.Length; i++) {
				
				if (objsToClear [i] != null && objsToClear [i].CompareTag ("Asteroid") || objsToClear [i].CompareTag ("Bullet")) {
					
					Destroy (objsToClear [i]);
				}
			}

			//Respawns the player and removes a life counter
			if (Input.GetKeyDown (KeyCode.Space)) {
				
				GameManager.gm.player.gameObject.SetActive (true);
				playerTf.SetPositionAndRotation (origin, initialAngle);

				switch (GameManager.gm.player.lives) {
				case 3:
					GameManager.gm.lifeCounters [0].SetActive (false);
					GameManager.gm.player.lives--;
					break;
				case 2:
					GameManager.gm.lifeCounters [1].SetActive (false);
					GameManager.gm.player.lives--;
					break;
				case 1:
					GameManager.gm.lifeCounters [2].SetActive (false);
					GameManager.gm.player.lives--;
					break;
				}
			}
		}
	}
}
