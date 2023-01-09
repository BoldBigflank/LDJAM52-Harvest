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
            bool goodOrientation = orientations[i] % 4 == 0;
            // If 5 is in position 1 and 10 is in position 3 is also good
            if (i == 5 && orientations[5] % 4 == 1 && orientations[10] % 4 == 3)
                goodOrientation = true;
            if (i == 10 && orientations[5] % 4 == 1 && orientations[10] % 4 == 3)
                goodOrientation = true;
            complete = complete && goodOrientation;
        }
        if (complete) {
            GameManager.Instance.PuzzleComplete("dirt");
        }
        
    }
}
