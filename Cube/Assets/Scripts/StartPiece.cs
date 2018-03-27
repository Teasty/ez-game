using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPiece : MonoBehaviour {

	public bool activated = true;
	public int number = 0;
	public Material[] material;
	Renderer rend;


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [1];
	}
}