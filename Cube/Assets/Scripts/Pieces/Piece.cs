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
    public int xLocation;
    public int yLocation;
    public int zLocation;
    Piece[] Pieces;
    protected Piece previous;


	// Use this for initialization
	void Start () {
        Debug.Log("SOSI");
	}
	
	// Update is called once per frame
    void Update (){
        
    }


    protected bool GetPieceTop(int x1, int y1, int z1)
    {
        bool res = false;
        Pieces = (Piece[])FindObjectsOfType(typeof(Piece));
        foreach (Piece p in Pieces)
        {
            if (p.xLocation == x1 & p.yLocation == y1 & p.zLocation == z1)
            {
                Debug.Log(xLocation.ToString() + yLocation.ToString() + zLocation.ToString() + "Top");
                if (p.activated)
                {
                    res = p.Exits[2];
                    break;
                }
            }
        }

        return res;
    }


    protected bool GetPieceRight(int x1, int y1, int z1)
    {
        bool res = false;
        Pieces = (Piece[])FindObjectsOfType(typeof(Piece));
        foreach (Piece p in Pieces)
        {
            if (p.xLocation == x1 & p.yLocation == y1 & p.zLocation == z1)
            {
                Debug.Log(xLocation.ToString() + yLocation.ToString() + zLocation.ToString() + "Right");
                if (p.activated)
                {
                    res = p.Exits[3];
                    break;
                }
            }
        }

        return res;
    }


    protected bool GetPieceBottom(int x1, int y1, int z1)
    {
        bool res = false;
        Pieces = (Piece[])FindObjectsOfType(typeof(Piece));
        foreach (Piece p in Pieces)
        {
            if (p.xLocation == x1 & p.yLocation == y1 & p.zLocation == z1)
            {
                Debug.Log(xLocation.ToString() + yLocation.ToString() + zLocation.ToString() + "Bottom");
                if (p.activated)
                {
                    res = p.Exits[0];
                    break;
                }
            }
        }

        return res;
    }


    protected bool GetPieceLeft(int x1, int y1, int z1)
    {
        bool res = false;
        Pieces = (Piece[])FindObjectsOfType(typeof(Piece));
        foreach (Piece p in Pieces)
        {
            if (p.xLocation == x1 & p.yLocation == y1 & p.zLocation == z1)
            {
                Debug.Log(xLocation.ToString() + yLocation.ToString() + zLocation.ToString() + "Left");
                if (p.activated)
                {
                    res = p.Exits[1];
                    break;
                }
            }
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