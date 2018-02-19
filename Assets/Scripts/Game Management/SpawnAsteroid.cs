using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour {

	/*
		Spawns an asteroid at one of eight random locations every three seconds after the game has started

		This component uses Time.time to track when to spawn the asteroids, so if the player doesn't immediately hit play then when they do multiple big asteroids will spawn simultaneously
		This was not intentional but it doesn't hurt the gameplay so I left it as it is

		The spawner also only keeps track of the total number of big asteroids so potentially a player could keep hitting big asteroids and the game would fill with lots of smaller asteroids
		This is intentional as it makes the game more challenging
	*/

	private Transform tf;
	private Vector3 spawnPosition;

	private float nextSpawnTime;
	private int pointNum;

	public GameObject enemyObj;

	// Use this for initialization
	void Start () {
		
		tf = GetComponent<Transform> ();
		nextSpawnTime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		//Spawns a big asteroid at a random location if there are no more than two other big asteorids on the screen and the game has started
		if (GameManager.gm.totalBigAsteroids < 3) {
			
			if (GameManager.gm.gameIsStarted == true) {

				//Spawns an asteroid after Time.time is bigger than the next spawn time resulting in an asteroid spawning every 3 seconds
				if (Time.time > nextSpawnTime) {

					pointNum = Random.Range (0, 8);
					switch (pointNum) {
					case 1:
						spawnPosition.Set (-22, 10, 0);
						Instantiate (enemyObj, spawnPosition, tf.rotation);
						GameManager.gm.totalBigAsteroids++;
						break;
					case 2:
						spawnPosition.Set (0, 10, 0);
						Instantiate (enemyObj, spawnPosition, tf.rotation);
						GameManager.gm.totalBigAsteroids++;
						break;
					case 3:
						spawnPosition.Set (22, 10, 0);
						Instantiate (enemyObj, spawnPosition, tf.rotation);
						GameManager.gm.totalBigAsteroids++;
						break;
					case 4:
						spawnPosition.Set (22, 0, 0);
						Instantiate (enemyObj, spawnPosition, tf.rotation);
						GameManager.gm.totalBigAsteroids++;
						break;
					case 5:
						spawnPosition.Set (22, -10, 0);
						Instantiate (enemyObj, spawnPosition, tf.rotation);
						GameManager.gm.totalBigAsteroids++;
						break;
					case 6:
						spawnPosition.Set (0, -10, 0);
						Instantiate (enemyObj, spawnPosition, tf.rotation);
						GameManager.gm.totalBigAsteroids++;
						break;
					case 7:
						spawnPosition.Set (-22, -10, 0);
						Instantiate (enemyObj, spawnPosition, tf.rotation);
						GameManager.gm.totalBigAsteroids++;
						break;
					case 8:
						spawnPosition.Set (-22, 0, 0);
						Instantiate (enemyObj, spawnPosition, tf.rotation);
						GameManager.gm.totalBigAsteroids++;
						break;
					}

					nextSpawnTime += 3.0f;
				}
			}
		}
	}
}
