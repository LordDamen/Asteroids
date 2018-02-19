using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidChunkMovement : MonoBehaviour {

	/*
		The movement for the smaller asteroid objects

		The smaller asteroids needed a seperate component for their movement since they don't orient themselves toward the player when they spawn

		Asteroids will warp to the other side of the screen if they go offscreen
	*/

	private Transform tf;
	private Vector3 warpPosition;

	public float speed;

	private float randomAngle;

	// Use this for initialization
	void Start () {

		tf = GetComponent<Transform> ();

		randomAngle = Random.Range(0, 360);
		tf.Rotate (0, 0, randomAngle);

	}
	
	// Update is called once per frame
	void Update () {

		//Asteroids move straight after they spawn
		tf.position += tf.right * speed;

		//Warps the object to the opposite side of the screen if the object moves too far off screen
		//This is different than the bullet or player movement because the asteroids would get stuck outside of the set boundaries if they warped based on their old position
		if (tf.position.x > 22.7f) {
			
			warpPosition.Set (-22, tf.position.y, 0);
			tf.SetPositionAndRotation (warpPosition, tf.rotation);
		}
		if (tf.position.x < -22.7f) {
			
			warpPosition.Set (22, tf.position.y, 0);
			tf.SetPositionAndRotation (warpPosition, tf.rotation);
		}
		if (tf.position.y > 10) {
			
			warpPosition.Set (tf.position.x, -9.5f, 0);
			tf.SetPositionAndRotation (warpPosition, tf.rotation);
		}
		if (tf.position.y < -10) {
			
			warpPosition.Set (tf.position.x, 9.5f, 0);
			tf.SetPositionAndRotation (warpPosition, tf.rotation);
		}
	}
}
