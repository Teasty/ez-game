using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

	public float speed;
	public SwipeController Controls;
	float yRotation, xRotation, zRotation;
	float piecerotation;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

		if (Controls.SwipeLeft) {
			Rotatey (90);
		}
		if (Controls.SwipeRight) {
			Rotatey (-90);
		}


		if (Controls.SwipeUp) {
			if (yRotation == 0)
				Rotatex (90);
			else if (yRotation == 90|| yRotation == -270)
				Rotatez (90);
			else if (yRotation == -90 || yRotation == 270)
				Rotatez (-90);
			else if (yRotation == 180 || yRotation == -180)
				Rotatex (-90);
		}

		if (Controls.SwipeDown) {
			if (yRotation == 0)
				Rotatex (-90);
			else if (yRotation == 90|| yRotation == -270)
				Rotatez (-90);
			else if (yRotation == -90 || yRotation == 270)
				Rotatez (90);
			else if (yRotation == 180 || yRotation == -180)
				Rotatex (90);
		}

		if (true) {
			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (xRotation, yRotation, zRotation), speed);
			}
	}

		

	public void Rotatey(float e){

		if (yRotation == 360|| yRotation == -360) {
			yRotation = 0;
		}

		yRotation += e;
		Debug.Log (xRotation.ToString() + " " + yRotation.ToString() + " " + zRotation.ToString());
	}
	public void Rotatex(float e){

		if (xRotation == 360 || xRotation == -360) {
			xRotation = 0;
		}

		xRotation += e;
	}
	public void Rotatez(float e){

		if (zRotation == 360 || zRotation == -360) {
			zRotation = 0;
		}

		zRotation += e;
	}
}
