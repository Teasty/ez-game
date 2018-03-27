using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceRotationScript : MonoBehaviour {

	public float pspeed;
	float realRotation;
	public SwipeController Controls;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.root.localEulerAngles.y != realRotation) {
			transform.localRotation = Quaternion.Lerp (transform.localRotation, Quaternion.Euler (realRotation+45, 90, 0), pspeed);
		}
	}
	void OnMouseDown (){
		RotateCube ();
	}

	public void RotateCube(){
		if (realRotation == 360) {
			realRotation = 0;
		}
		realRotation += 90;


	}
}
