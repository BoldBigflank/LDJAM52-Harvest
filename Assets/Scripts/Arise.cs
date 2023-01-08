using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arise : MonoBehaviour
{
    private Vector3 start;
    private float damping = 0.1f;

    private void Awake() {
        start = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z
        );
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y - 3.0f,
            transform.position.z
        );
    }
    private void FixedUpdate() {
        transform.position = Vector3.Lerp(transform.position, start, damping);
    }
}
