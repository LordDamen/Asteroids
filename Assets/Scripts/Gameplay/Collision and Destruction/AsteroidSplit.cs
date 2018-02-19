using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSplit : MonoBehaviour {

	/*
		Splits a game object into two other game objects when the original is destroyed

		Used for the big and medium sized asteroids to split into smaller asteroids, giving the game a bit more challenge
	*/

	public GameObject firstSplitObject;
	public GameObject secondSplitObject;

	private Transform tf;
	private Vector3 firstSpawnPosition;
	private Vector3 secondSpawnPosition;

	// Use this for initialization
	void Start () {
		
		tf = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		//Sets the positions of the new game objects so they are less likely to stick to each other when instantiated
		firstSpawnPosition.Set (tf.position.x + tf.up.x * 0.1f, tf.position.y + tf.up.y * 0.1f, 0);
		secondSpawnPosition.Set (tf.position.x + tf.right.x * 0.1f, tf.position.y + tf.right.y * 0.1f, 0);
	}

	void OnDestroy () {
		
		//Spawns the stored game objects
		Instantiate (firstSplitObject, firstSpawnPosition, tf.rotation);
		Instantiate (secondSplitObject, secondSpawnPosition, tf.rotation);
	}
}
