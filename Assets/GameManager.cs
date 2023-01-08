using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance is null)
                Debug.LogError("Game Manager is NULL");
            return _instance;
        }
    }

    public GameObject WaterScene;
    public GameObject DirtScene;
    public GameObject SeedScene;
    public GameObject SunScene;
    public GameObject FlowerScene;

    public AudioClip SmallFlourish;
    public AudioClip LargeFlourish;
    AudioSource ac;

    public int totalComplete { get; set; }

    private void Awake() {
        _instance = this;
        Input.simulateMouseWithTouches = true;
        ac = GetComponent<AudioSource>();
    }

    public void PuzzleComplete(string name) {
        if (name == "water") {
            WaterScene.SetActive(true);
        }
        if (name == "dirt") {
            DirtScene.SetActive(true);
        }
        if (name == "seed") {
            SeedScene.SetActive(true);
        }
        if (name == "sun") {
            SunScene.SetActive(true);
        }
        totalComplete += 1;
        if (totalComplete == 4) {
            ac.PlayOneShot(LargeFlourish, 0.7f);
            FlowerScene.SetActive(true);
        } else {
            ac.PlayOneShot(SmallFlourish, 0.7f);
        }
    }
}
