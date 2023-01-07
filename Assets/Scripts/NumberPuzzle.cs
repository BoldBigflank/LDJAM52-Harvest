using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberPuzzle : MonoBehaviour
{
    public GameObject display;
    bool complete;
    string displayText;
    // Start is called before the first frame update
    void Start()
    {
        complete = false;
        displayText = "";
        UpdateText();
    }

    void UpdateText() {
        display.GetComponent<TextMeshPro>().text = displayText;
        display.GetComponent<TextMeshPro>().color = (displayText.Length == 3 && displayText != "425") ? Color.red : Color.white;
    }

    public void ButtonPressed(int number) {
        if (complete) return;
        // Reset if necessary
        if (displayText.Length >= 3) displayText = "";
        // Add the number to the display
        displayText = "" + displayText + number.ToString();
        UpdateText();
        if (displayText == "425") {
            complete = true;
            display.GetComponent<TextMeshPro>().color = Color.green;
        }

    }
}
