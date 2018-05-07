using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LPiece : Piece
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
        Debug.Log(transform.rotation.x.ToString() + " " + transform.localRotation.x.ToString());
        this.transform.localRotation = Quaternion.Lerp(this.transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, -realRotation + transform.localRotation.z), speed);
        Check();
    }

    void OnMouseDown()
    {
        RotateLPiece();
        Reset();
        RotateValues();
    }

    void RotateLPiece()
    {
        realRotation += 90;

        if (realRotation == 360)
        {
            realRotation = 0;
        }
    }


    protected void Check()
    {
        if ((Exits[0] & GetPieceTop()) || (Exits[1] & GetPieceRight()))
        {
            Set();
        }
        else if ((Exits[1] & GetPieceRight()) || (Exits[2] & GetPieceBottom()))
        {
            Set();
        }
        else if ((Exits[2] & GetPieceBottom()) || (Exits[3] & GetPieceLeft()))
        {
            Set();
        }
        else if ((Exits[3] & GetPieceLeft()) || (Exits[0] & GetPieceTop()))
        {
            Set();
        } else {
            Reset();
        }
    }
    void RotatePiece()
    {
        System.Random random = new System.Random();
        for (int i = 0; i < random.Next(3); i++)
        {
            RotateLPiece();
            Check();
            RotateValues();
            Reset();
        }
    }
}
