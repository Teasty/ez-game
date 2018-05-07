﻿using System.Collections;
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
        if ((Exits[0] & GetPieceTop()) || (Exits[2] & GetPieceBottom()))
        {
            Set();
        }
        else if ((Exits[1] & GetPieceRight()) || (Exits[3] & GetPieceLeft()))
        {
            Set();
        } else
        {
            Reset();
        }
    }
    void RotatePiece()
    {
        System.Random random = new System.Random();
        for (int i = 0; i < random.Next(3); i++)
        {
            RotateIPiece();
            Check();
            RotateValues();
            Reset();
        }
    }
}
