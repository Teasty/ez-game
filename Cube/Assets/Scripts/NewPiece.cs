using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPiece : MonoBehaviour {

	public float pspeed;
	public bool activated = false;
	public int number;
	public Material[] material;
	public SwipeController Controls;
	public Piece previous;
	float realRotation;
	Renderer rend;


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];
	}

	// Update is called once per frame
	void Update () {
		transform.localRotation = Quaternion.Lerp (transform.localRotation, Quaternion.Euler (realRotation, 90, 0), pspeed);
		if (!activated){
			Check();
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
		Reset ();
		activated = false;
	}


	void Check(){
		if ((realRotation == 0 || realRotation == 180 || realRotation == 360) && previous.activated){
			SwichMaterial(1);
			activated = true;
		}
	}


	//	void FindPrevious (){
	//		Piece[] pieces = Piece;
	//		foreach(var piece in pieces){
	//			if ( this.number + 1 == piece.number) {
	//				previous = piece;
	//				break;
	//			}
	//		}
	//	}

	void Reset(){
		activated = false;
		SwichMaterial (0);
	}


	public void SwichMaterial(int n){
		rend.sharedMaterial = material [n];
	}
}