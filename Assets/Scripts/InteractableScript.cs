using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Debug.Log("OnMouseDown");
    }
    private void OnMouseDrag() {
        Debug.Log("OnMouseDrag");
    }
    private void OnMouseEnter() {
        Debug.Log("OnMouseEnter");
    }
    private void OnMouseExit() {
        Debug.Log("OnMouseExit");
    }
    private void OnMouseOver() {
        Debug.Log("OnMouseOver");
    }
    private void OnMouseUp() {
        Debug.Log("OnMouseUp");
    }
    private void OnMouseUpAsButton() {
        Debug.Log("OnMouseUpAsButton");
    }
}
