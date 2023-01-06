using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        Input.simulateMouseWithTouches = true;
    }

    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Click!");
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray))
                {
                    // Create a particle if hit
                    Instantiate(particle, transform.position, transform.rotation);
                }
            }
        }
    }
}
