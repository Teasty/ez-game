using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

	public float speed = 200;
	public SwipeController Controls;
	float yRotation, xRotation, zRotation;
	float piecerotation;
	private GameObject endRotation;

	void Start(){
		endRotation = new GameObject();
	}

//	void Update () {
//		if( Input.GetKeyDown( KeyCode.RightArrow ) ){
//			endRotation.transform.Rotate(Vector3.forward, 90, Space.World);
//		}
//		if( Input.GetKeyDown( KeyCode.LeftArrow ) ){
//			endRotation.transform.Rotate(Vector3.forward, -90, Space.World);
//		}
//
//
//		if( Input.GetKeyDown( "a" ) ){
//			endRotation.transform.Rotate(Vector3.up, 90, Space.World);
//		}
//		if( Input.GetKeyDown( "d" ) ){
//			endRotation.transform.Rotate(Vector3.up, -90, Space.World);
//		}
//
//
//		if( Input.GetKeyDown( "w" ) ){
//			endRotation.transform.Rotate(Vector3.left, 90, Space.World);
//		}
//		if( Input.GetKeyDown( "s") ){
//			endRotation.transform.Rotate(Vector3.left, -90, Space.World);
//		}
//
//
//	}
	// Update is called once per frame
	void Update () {

		if (Controls.SwipeLeft) {
			endRotation.transform.Rotate (Vector3.up, 90, Space.World);
		}
		if (Controls.SwipeRight) {
			endRotation.transform.Rotate (Vector3.up, -90, Space.World);
		}


		if (Controls.SwipeUp) {
//			if (yRotation == 0)
			endRotation.transform.Rotate (Vector3.left, -90, Space.World);
//			else if (yRotation == 90|| yRotation == -270)
//				Rotatez (90);
//			else if (yRotation == -90 || yRotation == 270)
//				Rotatez (-90);
//			else if (yRotation == 180 || yRotation == -180)
//				Rotatex (-90);
		}

		if (Controls.SwipeDown) {
//			if (yRotation == 0)
			endRotation.transform.Rotate (Vector3.left, 90, Space.World);
//			else if (yRotation == 90|| yRotation == -270)
//				Rotatez (-90);
//			else if (yRotation == -90 || yRotation == 270)
//				Rotatez (90);
//			else if (yRotation == 180 || yRotation == -180)
//				Rotatex (90);
		}
		this.transform.rotation = Quaternion.Lerp (this.transform.rotation, endRotation.transform.rotation, speed);
	}

		

//	public void Rotatey(float e){
//
//		if (yRotation == 360|| yRotation == -360) {
//			yRotation = 0;
//		}
//
//		yRotation = transform.rotation.eulerAngles.y + e;
//		Debug.Log (xRotation.ToString() + " " + yRotation.ToString() + " " + zRotation.ToString());
//	}
//	public void Rotatex(float e){
//
//		if (xRotation == 360 || xRotation == -360) {
//			xRotation = 0;
//		}
//
//		xRotation = transform.rotation.eulerAngles.x + e;
//	}
//	public void Rotatez(float e){
//
//		if (zRotation == 360 || zRotation == -360) {
//			zRotation = 0;
//		}
//
//		zRotation = transform.rotation.eulerAngles.z + e;
//	}
}
