using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTransform : MonoBehaviour
{
    public float rotation = 0;
    public string rotationError = "";
    public void Rotation(string rotation)
    {
        if(rotation == "")
        {
            this.rotation = 0;
            return;
        }
        try
        {
            this.rotation = float.Parse(rotation);
            rotationError = "";
        } catch (System.FormatException e)
        {
            rotationError = "Please input a number";
        }
        
    }
}
