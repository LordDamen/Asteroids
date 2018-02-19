using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	/*
		Sets the movement of bullet objects

		Bullets will warp to the opposite side of the screen if they go too far off screen
	*/

	private Transform tf;
	private Vector3 warpPos;

	public float speed;

	// Use this for initialization
	void Start () {
		
		tf = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Always moves straight in the direction it was spawned
		tf.position += tf.up * speed;

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
