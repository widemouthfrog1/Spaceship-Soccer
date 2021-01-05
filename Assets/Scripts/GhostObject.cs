using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostObject : MonoBehaviour
{
    public List<GameObject> shipParts;
    public GameObject _base;
    private GameObject globalVariables;
    private GameObject ship;
    EditorControls editorControls;
    public string last = "None";
    public Vector2 mouseInput;
    bool click = false;
    bool canEdit = true;
    // Start is called before the first frame update
    void Start()
    {
        
        globalVariables = GameObject.Find("/Global Variables");
        editorControls = globalVariables.GetComponent<Controls>().editorControls;
        ship = GameObject.Find("/Ship");
        editorControls.Edit.EditPosition.performed += v =>
        {
            mouseInput = v.ReadValue<Vector2>();
        };
        editorControls.Edit.Edit.started += v =>
        {
            click = true;
        };
        editorControls.Edit.DisableEdits.started += v =>
        {
            canEdit = false;
        };
        editorControls.Edit.DisableEdits.canceled += v =>
        {
            canEdit = true;
        };
    }

    // Update is called once per frame
    void Update()
    {

        if (globalVariables.GetComponent<Buttons>().selected == "None")
        {
            _base = null;
        }
        else
        {
            foreach (GameObject part in shipParts)
            {
                if (globalVariables.GetComponent<Buttons>().selected == part.name)
                {
                    _base = part;
                }
            }
        }

        if (_base != null && last != _base.name)
        {
            transform.localScale = _base.transform.localScale;
            MeshFilter filter = GetComponent<MeshFilter>();
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            filter.mesh = _base.GetComponent<MeshFilter>().sharedMesh;
            renderer.material = new Material(_base.GetComponent<MeshRenderer>().sharedMaterial);
            Color opacity = renderer.sharedMaterial.color;
            opacity.r = 0.1f;
            renderer.sharedMaterial.color = opacity;
            last = _base.name;
        }
        else if (_base == null)
        {
            transform.localScale = new Vector3(1, 1, 1);
            MeshFilter filter = GetComponent<MeshFilter>();
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            filter.mesh = null;
            renderer.material = null;
            last = "None";
        }

        if (_base != null)
        {
            Ray ray = Camera.main.ScreenPointToRay(mouseInput);
            RaycastHit hit;
            bool foundShip = false;
            Vector3 min = new Vector3();
            Vector3 max = new Vector3();
            Vector3 boxSpaceHit = new Vector3();
            RaycastHit originalHit = new RaycastHit();
            Quaternion q = new Quaternion();
            float angle = -1;
            if (canEdit && Physics.Raycast(ray, out hit, 50))
            {
                
                if (hit.transform.parent != null && hit.transform.parent.gameObject.name == "Ship")
                {
                    GameObject hitPart = hit.transform.gameObject;
                    Collider hitCollider = hitPart.GetComponent<Collider>();
                    if (hitCollider.GetType().ToString() == "UnityEngine.BoxCollider")
                    {
                        BoxCollider box = hitPart.GetComponent<BoxCollider>();
                        Vector3 scale = hit.transform.localScale;
                        Vector3 size = new Vector3(box.size.x * scale.x, box.size.y * scale.y, box.size.z * scale.z);
                        min = box.center - size / 2;
                        max = box.center + size / 2;
                        //rotate hit point into correct space
                        boxSpaceHit = box.center + Quaternion.Inverse(hit.transform.rotation) * (hit.point-box.center);
                        angle = Vector3.Angle(boxSpaceHit, hit.point);
                        q = hit.transform.rotation;
                        originalHit = hit;
                        //check x,y,z values against min max to find face that was hit
                        

                    }
                    Vector3 o = hit.transform.up;
                    Vector3 n = hit.normal;
                    Vector3 newForward = Vector3.ProjectOnPlane(o, n);
                    Debug.Log(newForward+ " " + transform.forward);
                    transform.localRotation = Quaternion.FromToRotation(new Vector3(0, 1, 0), n);
                    float r = globalVariables.GetComponent<PartTransform>().rotation;
                    if (n != o && n != -o)
                    {
                        transform.Rotate(n, Vector3.SignedAngle(transform.forward, newForward, n), Space.World);
                    }
                    transform.Rotate(n, r, Space.World);
                    transform.position = hit.point + transform.localRotation * _base.transform.position;
                    foundShip = true;
                }
            }
            if (!foundShip)
            {
                transform.position = new Vector3(0, -100);
            }
            else
            {
                if (click && _base != null)
                {

                    float qAngle = 0;
                    Vector3 axis = Vector3.zero;
                    transform.localRotation.ToAngleAxis(out qAngle, out axis);
                    Debug.Log(originalHit.normal);
                    Debug.Log("Local: " + axis + " " + qAngle);
                    GameObject obj = Instantiate(_base, transform.position, transform.rotation, ship.transform);

                    
                    obj.name = _base.name;
                }
            }

        }
        if (click)
        {
            click = false;
        }
    }
}
