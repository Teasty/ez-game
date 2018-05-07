using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPiece : Piece {

    // Use this for initialization
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Check(); 
    }

    protected void Check()
    {
        if (Exits[0] & GetPieceTop())
        {
            Set();
        }
        else if (Exits[1] & GetPieceRight())
        {
            Set();
        }
        else if (Exits[2] & GetPieceRight())
        {
            Set();
        }
        else if (Exits[3] & GetPieceRight())
        {
            Set();
        } else{
            Reset();
        }
    }


}
