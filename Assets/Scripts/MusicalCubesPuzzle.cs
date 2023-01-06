using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicalCubesPuzzle : MonoBehaviour
{
    private int puzzleIndex;
    private int puzzleLength;
    private bool complete;
    public GameObject[] musicalCubes;
    // Start is called before the first frame update
    void Start()
    {
        complete = false;
        puzzleIndex = 0;
        puzzleLength = 8;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void NotePlayed(int soundIndex) {
        if (complete == true) return;
        Debug.Log("NotePlayed: " + soundIndex + " compared to: " + puzzleIndex);
        if (soundIndex == puzzleIndex) {
            Debug.Log("Correct!");
            puzzleIndex += 1;
            // TODO: Win condition
            if (puzzleIndex == puzzleLength) {
                Debug.Log("Winner!");
                complete = true;
            }
        } else {
            Debug.Log("Wrong!");
            puzzleIndex = 0;
        }
    }
}
