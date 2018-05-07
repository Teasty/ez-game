using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPiece : Piece
{

    float speed = 0.5f;
    int realRotation;
    // Use this for initialization
    void Start()
    {
        SwitchMaterial(0);
        RotatePiece();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localRotation = Quaternion.Lerp(this.transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, transform.localRotation.z - realRotation), speed);
        Check();
    }

    void OnMouseDown()
    {
        RotateTPiece();
        Reset();
        RotateValues();
       

    }

    void RotateTPiece()
    {
        realRotation += 90;

        if (realRotation == 360)
        {
            realRotation = 0;
        }
    }


    protected void Check()
    {
        if ((Exits[0] & GetPieceTop()) || (Exits[1] & GetPieceRight()) || (Exits[2] & GetPieceBottom()))
        {
            Set();
        }
        else if ((Exits[1] & GetPieceRight()) || (Exits[2] & GetPieceBottom()) || (Exits[3] & GetPieceLeft()))
        {
            Set();
        }
        else if ((Exits[2] & GetPieceBottom()) || (Exits[3] & GetPieceLeft()) || (Exits[0] & GetPieceTop()))
        {
            Set();
        }
        else if ((Exits[3] & GetPieceLeft()) || (Exits[0] & GetPieceTop()) || (Exits[1] & GetPieceRight()))
        {
            Set();
        }
        else
        {
            Reset();
        }
    }

    void RotatePiece()
    {
        System.Random random = new System.Random();
        for (int i = 0; i < random.Next(3); i++)
        {
            RotateTPiece();
            Check();
            RotateValues();
            Reset();
        }
    }
}
