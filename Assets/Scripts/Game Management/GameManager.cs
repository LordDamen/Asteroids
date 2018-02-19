using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager gm;

	//Stored objects and object arrays to be referenced in other code
	public Player player;
	public GameObject[] lifeCounters;
	public GameObject playButton;
	public GameObject gameOverScreen;

	//Game manager variables necessary for other code
	public bool gameIsStarted;
	public int totalBigAsteroids;

	void Awake () {

		//Makes the game manager a singleton object
		if (gm == null) {
			gm = this;
		} else {
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
		gameIsStarted = false;
		totalBigAsteroids = 0;
	}
	
	// Update is called once per frame
	void Update () {

		//Resets the game when the player runs out of lives
		if (player.lives == 0) {
			
			gameIsStarted = false; //Deactivates object movement and spawning

			//Shows the game over screen and gives the option to play again
			playButton.SetActive (true);
			gameOverScreen.SetActive (true);
			for (int i = 0; i < lifeCounters.Length; i++) {
				
				lifeCounters [i].SetActive (true);
			}
				
			player.lives = 3;
		}
	}
}
