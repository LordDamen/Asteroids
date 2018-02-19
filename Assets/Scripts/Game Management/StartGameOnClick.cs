using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameOnClick : MonoBehaviour {

	/*
		Removes the play button and game over screen (if applicable) and begins the game
	*/

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp () {
		
		gameObject.SetActive(false);
		GameManager.gm.gameIsStarted = true;

		if (GameManager.gm.gameOverScreen.activeInHierarchy == true) {
			
			GameManager.gm.gameOverScreen.SetActive (false);
		}
	}
}
