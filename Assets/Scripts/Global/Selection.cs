using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    public GameObject selection = null;
    public bool selecting = false;

    public void Selecting(bool s)
    {
        selecting = s;
    }

}
