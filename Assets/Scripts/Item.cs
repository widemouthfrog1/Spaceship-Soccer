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
            gameObject.AddComponent<Button>();
            button = GetComponent<Button>();
        }
        
        button.onClick.AddListener(() => globalVariables.GetComponent<Buttons>().SetSelected(item.name));
        button.onClick.AddListener(() => globalVariables.GetComponent<Selection>().Selecting(false));
        button.onClick.AddListener(() => globalVariables.GetComponent<GhostVariables>().SetGhostActive(true));
        transform.Find("Text").GetComponent<Text>().text = item.name;

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
