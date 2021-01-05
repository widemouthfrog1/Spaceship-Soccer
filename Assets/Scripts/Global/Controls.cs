using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public EditorControls editorControls;
    // Start is called before the first frame update
    void Awake()
    {
        editorControls = new EditorControls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
