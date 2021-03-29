using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateGizmos : MonoBehaviour
{
    public GameObject gizmo;
    bool canTranslate = true;
    Bounds globalBounds;
    GameObject xGizmo;
    GameObject yGizmo;
    GameObject zGizmo;
    public Vector2 mouseInput;
    public Vector2 mouseDelta;
    EditorControls editorControls;
    private GameObject globalVariables;
    bool leftButtonPressed = false;
    bool wasPressed = false;
    string activeGizmo = "";

    // Start is called before the first frame update
    void Start()
    {
        globalVariables = GameObject.Find("/Global Variables");
        editorControls = globalVariables.GetComponent<Controls>().editorControls;
        editorControls.Edit.MousePosition.performed += v =>
        {
            mouseInput = v.ReadValue<Vector2>();
        };
        editorControls.Edit.MouseDelta.performed += v =>
        {
            mouseDelta = v.ReadValue<Vector2>();
        };
        editorControls.Edit.LeftMouse.started += v =>
        {
            leftButtonPressed = true;
        };
        editorControls.Edit.LeftMouse.canceled += v =>
        {
            leftButtonPressed = false;
        };


        globalBounds = GetComponent<Collider>().bounds;

        xGizmo = Instantiate(gizmo, transform.position + new Vector3(globalBounds.max.x - transform.position.x + 0.5f, 0, 0), transform.rotation, transform);
        xGizmo.name = "X";
        xGizmo.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        Vector3 cross = Vector3.Cross(xGizmo.transform.up, Vector3.right);
        xGizmo.transform.Rotate(cross, Vector3.SignedAngle(xGizmo.transform.up, Vector3.right, cross), Space.World);
        xGizmo.transform.Rotate(Vector3.right, Vector3.SignedAngle(xGizmo.transform.right, Vector3.up, Vector3.right), Space.World);

        yGizmo = Instantiate(gizmo, transform.position + new Vector3(0, globalBounds.max.y - transform.position.y + 0.5f, 0), transform.rotation, transform);
        yGizmo.name = "Y";
        yGizmo.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        cross = Vector3.Cross(yGizmo.transform.up, Vector3.up);
        yGizmo.transform.Rotate(cross, Vector3.SignedAngle(yGizmo.transform.up, Vector3.up, cross), Space.World);
        yGizmo.transform.Rotate(Vector3.up, Vector3.SignedAngle(yGizmo.transform.right, Vector3.forward, Vector3.up), Space.World);

        zGizmo = Instantiate(gizmo, transform.position + new Vector3(0, 0, globalBounds.max.z - transform.position.z + 0.5f), transform.rotation, transform);
        zGizmo.name = "Z";
        zGizmo.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        cross = Vector3.Cross(zGizmo.transform.up, Vector3.forward);
        zGizmo.transform.Rotate(cross, Vector3.SignedAngle(zGizmo.transform.up, Vector3.forward, cross), Space.World);
        zGizmo.transform.Rotate(Vector3.forward, Vector3.SignedAngle(zGizmo.transform.right, Vector3.up, Vector3.forward), Space.World);

    }

    // Update is called once per frame
    void Update()
    {   
        if(leftButtonPressed && activeGizmo.Equals("") && canTranslate)
        {
            Ray ray = Camera.main.ScreenPointToRay(mouseInput);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 50))
            {
                activeGizmo = hit.transform.name;
            }
            if((activeGizmo.Equals("X") || activeGizmo.Equals("Y") || activeGizmo.Equals("Z"))){
                globalVariables.GetComponent<GhostVariables>().SetGhostActive(false);
            }
            
        }
        if(leftButtonPressed && canTranslate && (activeGizmo.Equals("X") || activeGizmo.Equals("Y") || activeGizmo.Equals("Z")))
        {
            wasPressed = true;
            if (activeGizmo.Equals("X"))
            {
                Vector3 dTemp = Camera.main.WorldToScreenPoint(xGizmo.transform.position) - Camera.main.WorldToScreenPoint(transform.position);
                Vector2 direction = new Vector2(dTemp.x, dTemp.y);
                transform.parent.position = new Vector3(transform.parent.position.x + (Vector2.Dot(direction, mouseDelta) / direction.magnitude)/80, transform.parent.position.y, transform.parent.position.z);
            }
            if (activeGizmo.Equals("Y"))
            {
                Vector3 dTemp = Camera.main.WorldToScreenPoint(yGizmo.transform.position) - Camera.main.WorldToScreenPoint(transform.position);
                Vector2 direction = new Vector2(dTemp.x, dTemp.y);
                transform.parent.position = new Vector3(transform.parent.position.x , transform.parent.position.y + (Vector2.Dot(direction, mouseDelta) / direction.magnitude) / 80, transform.parent.position.z);
            }
            if (activeGizmo.Equals("Z"))
            {
                Vector3 dTemp = Camera.main.WorldToScreenPoint(zGizmo.transform.position) - Camera.main.WorldToScreenPoint(transform.position);
                Vector2 direction = new Vector2(dTemp.x, dTemp.y);
                transform.parent.position = new Vector3(transform.parent.position.x , transform.parent.position.y, transform.parent.position.z + (Vector2.Dot(direction, mouseDelta) / direction.magnitude) / 80);
            }
        }
        //Debug.Log(wasPressed);
        if (!leftButtonPressed && wasPressed)
        {
            globalVariables.GetComponent<GhostVariables>().SetGhostActive(true);
            activeGizmo = "";
        }
        
    }
}
