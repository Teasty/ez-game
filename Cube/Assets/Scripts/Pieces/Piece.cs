using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public bool[] Exits;
    public bool activated;
    protected bool red;
    protected bool blue;
    protected bool green;
    protected bool yellow;
    protected Piece previous;
    public Piece[] Near;


	// Use this for initialization
	void Start () {
        Debug.Log("SOSI");
	}
	
	// Update is called once per frame
    void Update (){
        
    }


    protected bool GetPieceTop()
    {
        bool res = false;

        if (Near[0].activated & Near[0].tag != "EndPiece")
                {
            res = Near[0].Exits[2];
                 
                }

        return res;
    }


    protected bool GetPieceRight()
    {
        bool res = false;
        if (Near[1].activated & Near[1].tag != "EndPiece")
        {
            res = Near[1].Exits[3];

        }

        return res;
    }


    protected bool GetPieceBottom()
    {
        bool res = false;
        if (Near[2].activated & Near[2].tag != "EndPiece")
        {
            res = Near[2].Exits[0];
        }

        return res;
    }


    protected bool GetPieceLeft()
    {
        bool res = false;
        if (Near[3].activated & Near[3].tag != "EndPiece")
        {
            res = Near[3].Exits[1];

        }

        return res;
    }


    protected void RotateValues(){
        bool aux = Exits[3];
        for (int i = Exits.Length - 2; i >=0 ; i--){
            Exits[i + 1] = Exits[i]; 
        }
        Exits[0] = aux;
    }


    protected void Set(){
        activated = true;
        SwitchMaterial(1);
        //Debug.Log("activated");
    }


    protected void Reset()
    {
        activated = false;
        SwitchMaterial(0);
    }


    protected void SwitchMaterial(int e){
        Renderer rend = GetComponent<Renderer>();
        switch (e)
        {
            case 0:
                rend.sharedMaterial = Resources.Load<Material>("Materials/white");
                //Debug.Log(rend.sharedMaterial.name);
                break;
            case 1:
                rend.sharedMaterial = Resources.Load<Material>("Materials/red");
                //Debug.Log(rend.sharedMaterial.name);
                break;
        }
    }
}