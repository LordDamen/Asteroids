using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitProgram : MonoBehaviour {

	/*
		When the user hits escape the application closes.

		Only works for the executable for this program since doing this in the editor would	close Unity.
	*/

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape)) {
			
			Application.Quit ();
		}
	}
}
