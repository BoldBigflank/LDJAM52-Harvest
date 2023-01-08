using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arise : MonoBehaviour
{
    private Vector3 start;
    private float damping = 0.1f;

    private void Awake() {
        start = new Vector3(
            transform.localPosition.x,
            transform.localPosition.y,
            transform.localPosition.z
        );
        transform.localPosition = new Vector3(
            transform.localPosition.x,
            transform.localPosition.y - 3.0f,
            transform.localPosition.z
        );
    }
    private void FixedUpdate() {
        transform.localPosition = Vector3.Lerp(transform.localPosition, start, damping);
    }
}
