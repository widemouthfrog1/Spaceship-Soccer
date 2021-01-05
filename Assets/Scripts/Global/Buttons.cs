using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public string selected = "None";
    public void SetSelected(string selection)
    {
        if(selected == selection)
        {
            selected = "None";
        }
        else
        {
            selected = selection;
        }
    }
}
