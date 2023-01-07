using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOutPuzzle : MonoBehaviour
{
    bool complete;
    // Start is called before the first frame update
    void Start()
    {
        complete = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckSolution() {
        if (complete) return;
        complete = true;
        foreach(Transform child in transform) {
            bool childOn = child.gameObject.GetComponent<LightsOutSphere>().on;
            complete = complete && childOn;
        }
        if (complete) {
            Debug.Log("Complete!");
        }
    }
}
