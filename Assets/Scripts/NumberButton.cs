using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberButton : MonoBehaviour
{
    public int num;
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton() {
        // TODO: Send the number to the parent
        parent.SendMessage("ButtonPressed", num);
        GameManager.Instance.PlayBlip();
    }
}
