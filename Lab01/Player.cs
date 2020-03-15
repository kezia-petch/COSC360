/*
	Created by: Lech Szymanski
				lechszym@cs.otago.ac.nz
				Oct 27, 2015			
*/

using UnityEngine;

public class Player : MonoBehaviour {

	public KeyCode moveLeft;
	public KeyCode moveRight;
	public KeyCode moveUp;
	public KeyCode moveDown;

	public float speed;

	// Update is called once per frame
	void Update () {
		float delta = speed * Time.deltaTime;
		
		if(Input.GetKey(moveRight)) {
			// Move to the right
			transform.Translate(new Vector3(speed * delta, 0, 0));	
		} else if(Input.GetKey(moveLeft)) {
			// Move to the left
			transform.Translate(new Vector3(-speed * delta, 0, 0));
		} else if(Input.GetKey(moveUp)) {
			//Rotate counterclockwise
			transform.Rotate( new Vector3(0, 0, speed * delta * 10));
		} else if(Input.GetKey(moveDown)) {
			//Rotate clockwise
			transform.Rotate( new Vector3(0, 0, -speed * delta * 10));
		}
	}
}