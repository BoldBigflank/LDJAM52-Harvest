using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPiece : MonoBehaviour
{
    GameObject parent;
    Renderer rend;
    public int pieceIndex;
    public bool locked;
    int orientation;
    Vector3 desiredAngles;
    float damping = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
        // Set the offset based on the pieceIndex
        rend = GetComponent<Renderer>();
        float offsetX = 0.0f + 0.25f * (pieceIndex % 4);
        float offsetY = 0.75f - 0.25f * Mathf.Floor(pieceIndex / 4);
        rend.material.SetTextureOffset("_MainTex", new Vector2(
            offsetX,
            offsetY
        ));
        if (!locked) orientation = Random.Range(1, 3);
        UpdateButton();
    }

    private void FixedUpdate() {
        // // Always rotate 
        // float targetOrientation = 90 * orientation;
        // while (targetOrientation <= transform.eulerAngles.z) {
        //     targetOrientation += 360;
        // }
        // transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(
        //     transform.eulerAngles.x,
        //     transform.eulerAngles.y,
        //     targetOrientation
        // ), damping);
    }

    void UpdateButton() {
        transform.eulerAngles = new Vector3(
            transform.eulerAngles.x,
            transform.eulerAngles.y,
            90 * orientation
        );
        int[] a = new int[] {
            pieceIndex, orientation
        };
        if (!locked) parent.SendMessage("PieceRotated", a);
    }

    private void OnMouseUpAsButton() {
        if (locked) return;
        orientation = (orientation + 1);
        UpdateButton();
    }
}
