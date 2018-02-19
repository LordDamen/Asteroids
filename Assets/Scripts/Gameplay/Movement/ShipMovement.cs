using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

	/*
		Sets the movement of the player object

		The player will warp to the opposite side of the screen if they go too far off screen
	*/

	private Transform tf;
	private Vector3 warpPos;

	public float rotationSpeed;
	public float linearSpeed;

	// Use this for initialization
	void Start () {
		
		tf = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Allows player-inputted movement after the game begins
		if (GameManager.gm.gameIsStarted == true) {

			if (Input.GetKey (KeyCode.A)) {
				
				tf.Rotate (0, 0, 1 * rotationSpeed);
			}
			if (Input.GetKey (KeyCode.D)) {
				
				tf.Rotate (0, 0, -1 * rotationSpeed);
			}
			if (Input.GetKey (KeyCode.W)) {
				
				tf.position += tf.up * linearSpeed;
			}
			if (Input.GetKey (KeyCode.S)) {
				
				tf.position -= tf.up * linearSpeed;
			}
		}

		//Warps the object based on its old position before it went off screen
		if (tf.position.x > 22.7 || tf.position.x < -22.7) {
			
			warpPos.Set (-tf.position.x, tf.position.y, 0);
			tf.SetPositionAndRotation (warpPos, tf.rotation);
		}
		if (tf.position.y > 10 || tf.position.y < -10) {
			
			warpPos.Set (tf.position.x, -tf.position.y, 0);
			tf.SetPositionAndRotation (warpPos, tf.rotation);
		}
	}
}
