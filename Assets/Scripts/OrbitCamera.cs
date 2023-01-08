using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform Focus;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.125f;

    public bool AllowRotate = true;
    public float RotationSpeed = 5.0f;
    private Vector3 _cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - Focus.position;
    }

    // Update is called once per frame
    void Update()
    {
        AllowRotate = Input.GetMouseButton(0);
    }
    private void LateUpdate() {
        if (AllowRotate) {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);
            _cameraOffset = camTurnAngle * _cameraOffset;

            Focus.LookAt(transform);

            Quaternion camPitchAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * RotationSpeed, Focus.right);
            _cameraOffset = camPitchAngle * _cameraOffset;
        }

        Vector3 newPos = Focus.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        transform.LookAt(Focus);
    }
}
