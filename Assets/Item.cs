using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    //Items need to set selecting to false
    public GameObject item;
    GameObject globalVariables;
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        globalVariables = GameObject.Find("/Global Variables");
        if (!TryGetComponent(out button))
        {
            Debug.LogError("Item must have button");
        }
        
        button.onClick.AddListener(() => globalVariables.GetComponent<Buttons>().SetSelected(name));
        button.onClick.AddListener(() => globalVariables.GetComponent<Selection>().Selecting(false));
        transform.Find("Text").GetComponent<Text>().text = name;

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
