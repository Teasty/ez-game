using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPiece : MonoBehaviour {

	public bool activated = false;
	public int number;
	public Material[] material;
	public Piece previous;
	Renderer rend;


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];
	}

	// Update is called once per frame
	void Update () {
			Check();

	}
		
	void Check(){
		if (!previous.activated) {
			SwichMaterial (0);
			activated = false;
		} else {
			SwichMaterial (1);
			activated = true;
		}
	}
		
	public void SwichMaterial(int n){
		rend.sharedMaterial = material [n];
	}
}
