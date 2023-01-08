using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPuzzle : MonoBehaviour
{
    bool complete;
    int[] orientations;
    // Start is called before the first frame update
    void Awake()
    {
        complete = false;
        orientations = new int[] {
                0,0,0,0,
                0,0,0,0,
                0,0,0,0,
                0,0,0,0
            };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PieceRotated(int[] a) {
        if (complete) return;
        int pieceIndex = a[0];
        int orientation = a[1];
        orientations[pieceIndex] = orientation;
        complete = true;

        for(int i = 0; i < orientations.Length; i++) {
            bool goodOrientation = orientations[i] == 0;
            // Piece 0 can be 0/2
            // 2 can be any
            // 6 also works in position 2 if piece 11 is in position 1
            // 12 can be any position
            // 15 can be any position
            complete = complete && goodOrientation;
        }
        if (complete) {
            GameManager.Instance.PuzzleComplete("dirt");
        }
        
    }
}
