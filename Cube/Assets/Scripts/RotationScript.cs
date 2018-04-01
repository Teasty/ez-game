using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

	public float speed = 200;
	public SwipeController Controls;
	private GameObject endRotation;

	void Start(){
		endRotation = new GameObject();
	}

	// Update is called once per frame
	void Update () {

		if (Controls.SwipeLeft) {
			endRotation.transform.Rotate (Vector3.up, 90, Space.World);
		}
		if (Controls.SwipeRight) {
			endRotation.transform.Rotate (Vector3.up, -90, Space.World);
		}


		if (Controls.SwipeUp) {
			endRotation.transform.Rotate (Vector3.left, -90, Space.World);
		}

		if (Controls.SwipeDown) {
			endRotation.transform.Rotate (Vector3.left, 90, Space.World);
		}
		this.transform.rotation = Quaternion.Lerp (this.transform.rotation, endRotation.transform.rotation, speed);
	}
}
