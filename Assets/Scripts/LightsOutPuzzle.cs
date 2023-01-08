using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOutPuzzle : MonoBehaviour
{
    bool complete;
    bool setup;
    // Start is called before the first frame update
    void Start()
    {
        complete = false;
        setup = true;
        foreach(Transform child in transform) {
            LightsOutSphere los = child.gameObject.GetComponent<LightsOutSphere>();
            if (los != null)
                los.Setup();
        }
        setup = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckSolution() {
        if (setup) return;
        if (complete) return;
        complete = true;
        foreach(Transform child in transform) {
            LightsOutSphere los = child.gameObject.GetComponent<LightsOutSphere>();
            if (los != null) {
                bool childOn = los.on;
                complete = complete && childOn;
            }
        }
        if (complete) {
            Debug.Log("Complete!");
            GameManager.Instance.PuzzleComplete("sun");
        }
    }
}
