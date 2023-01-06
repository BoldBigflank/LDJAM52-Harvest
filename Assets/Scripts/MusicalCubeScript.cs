using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicalCubeScript : MonoBehaviour
{
    AudioSource audioData;
    string noteName;
    public GameObject puzzle;
    public int orderIndex;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        noteName = audioData.clip.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton() {
        audioData.Play(0);
        puzzle.SendMessage("NotePlayed", orderIndex);
    }
}
