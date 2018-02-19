using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAsteroidMovement : MonoBehaviour {

	/*
		Sets the movement of the bigger asteroids

		When the asteroids are spawned they set their rotation to look at the Player
		
		When the game begins they will move in the direction of the initial angle

		Asteroids will warp to the other side of the screen if they go offscreen
	*/

	private Transform tf;
	private Transform playertf;
	private Vector3 warpPosition;

	private float initialAngle;

	public float speed;

	// Use this for initialization
	void Start () {
		
		tf = GetComponent<Transform> ();
		playertf = GameManager.gm.player.GetComponent<Transform> ();

		//Sets the angle of the object to point at the player by finding the arc-tangent of the object relative to the player poition
		initialAngle = Mathf.Atan2((playertf.position.y - tf.position.y), (playertf.position.x - tf.position.x)) * 180 / Mathf.PI;
		tf.Rotate(0, 0, initialAngle);
	}

	// Update is called once per frame
	void Update () {

		//Asteroids move straight after the game begins
		if (GameManager.gm.gameIsStarted == true) {
			tf.position += tf.right * speed;
		}

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
