/*
	Created by: Lech Szymanski
				lechszym@cs.otago.ac.nz
				Oct 27, 2015			
*/

using UnityEngine;

public class Planet : MonoBehaviour {

	// Rate of the 'bob' movement
	public float bobRate;

	// Scale of the 'bob' movement
	public float bobScale;

	// Update is called once per frame
	void Update () {
		// Change in vertical distance 
		float dy = bobScale * Mathf.Sin(bobRate * Time.time);
		
		// Move the game object on the vertical axis
		transform.Translate(new Vector3(0, dy, 0));
	}
}