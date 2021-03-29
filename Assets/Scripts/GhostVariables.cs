using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostVariables : MonoBehaviour
{
    public bool ghostActive = false;

    public void SetGhostActive(bool b)
    {
        ghostActive = b;
    }
}
