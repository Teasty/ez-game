using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPiece : Piece
{

    float speed = 0.5f;
    int realRotation;
    // Use this for initialization
    void Start()
    {
        SwitchMaterial(0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localRotation = Quaternion.Lerp(this.transform.localRotation, Quaternion.Euler(realRotation, 90, 0), speed);
        Check();
    }

    void OnMouseDown()
    {
        RotateIPiece();
        Reset();
        RotateValues();
        Check();
    }

    void RotateIPiece()
    {
        realRotation += 90;

        if (realRotation == 360)
        {
            realRotation = 0;
        }
    }


    protected void Check()
    {
        if ((Exits[0] & GetPieceTop(xLocation, yLocation + 1, zLocation)) || (Exits[2] & GetPieceBottom(xLocation, yLocation - 1, zLocation)))
        {
            Debug.Log("|");
            Set();
        }
        else if ((Exits[1] & GetPieceRight(xLocation + 1, yLocation, zLocation)) || (Exits[3] & GetPieceLeft(xLocation - 1, yLocation, zLocation)))
        {
            Debug.Log("-");
            Set();
        }
    }
}
