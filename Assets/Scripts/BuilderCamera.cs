using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderCamera : MonoBehaviour
{
    public Transform pointTowards;
    EditorControls editorControls;
    public float distance = 6;
    public float lastDistance = -1;
    public Vector2 mouseInput;
    public float zoomInput;
    public bool rotateEnabled;
    public bool zoomEnabled;
    public bool cameraEnabled;
    public float yAngle = 0;
    public float heightAngle = 60;
    public Vector3 direction;

    private void Awake()
    {
        editorControls = GameObject.Find("/Global Variables").GetComponent<Controls>().editorControls;
        editorControls.Enable();
        editorControls.Camera.Rotate.performed += v =>
        {
            mouseInput = v.ReadValue<Vector2>();
        };
        editorControls.Camera.Zoom.performed += v =>
        {
            zoomInput = v.ReadValue<float>() / 120;
        };
        editorControls.Camera.RotateStart.started += v =>
        {
            rotateEnabled = v.ReadValue<float>() == 1;
        };
        editorControls.Camera.RotateStart.canceled += v =>
        {
            rotateEnabled = false;
        };
        editorControls.Camera.ZoomStart.started += v =>
        {
            zoomEnabled = v.ReadValue<float>() == 1;
        };
        editorControls.Camera.ZoomStart.canceled += v =>
        {
            zoomEnabled = false;
        };
        editorControls.Camera.EnableCameraControls.started += v =>
        {
            cameraEnabled = v.ReadValue<float>() == 1;
        };
        editorControls.Camera.EnableCameraControls.canceled += v =>
        {
            cameraEnabled = false;
        };

    }
    // Start is called before the first frame update
    void Start()
    {
        distance = (transform.position - pointTowards.position).magnitude;

    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(0, 0, -1);
        if (rotateEnabled && cameraEnabled)
        {
            yAngle += mouseInput.x / 10;
            heightAngle += mouseInput.y / 10;
            if(heightAngle < 40)
            {
                heightAngle = 40;
            }
            if (heightAngle > 140)
            {
                heightAngle = 140;
            }
        }
        direction = new Vector3(Mathf.Sin(Mathf.Deg2Rad*heightAngle)*Mathf.Sin(Mathf.Deg2Rad * yAngle), Mathf.Cos(Mathf.Deg2Rad * heightAngle), Mathf.Sin(Mathf.Deg2Rad * heightAngle)*Mathf.Cos(Mathf.Deg2Rad * yAngle));

        distance -= zoomInput / 10;
        if(distance < 3)
        {
            distance = 3;
        }
        if (distance > 6.5f)
        {
            distance = 6.5f;
        }
        if (Mathf.Abs(lastDistance - distance) > 0.01f)
        {
            Vector3 newPosition = direction*distance;
            transform.position = pointTowards.position + newPosition;
            lastDistance = distance;
        }
        if(mouseInput.x != 0 || mouseInput.y != 0)
        {
            Vector3 newPosition = direction * distance;
            transform.position = pointTowards.position + newPosition;
        }
        transform.LookAt(pointTowards.position);
    }
}
