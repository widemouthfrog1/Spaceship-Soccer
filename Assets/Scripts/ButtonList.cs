using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonList : MonoBehaviour
{
    public Item baseItem;
    public List<GameObject> items;
    public List<Item> buttons;
    public float buttonHeight;
    public float buttonSpace;
    public float edge;
    public float scrollBarWidth;
    private RectTransform bounds;
    
    // Start is called before the first frame update
    void Start()
    {
        bounds = GetComponent<RectTransform>();
        
        //size of button list
        bounds.sizeDelta = new Vector2(transform.parent.GetComponent<RectTransform>().sizeDelta.x, Mathf.Max(edge * 2 + buttonHeight * items.Count + buttonSpace*(items.Count - 1), transform.parent.GetComponent<RectTransform>().sizeDelta.y));

        for(int i = 0; i < items.Count; i++)
        {
            buttons.Add(Instantiate(baseItem, transform));
            buttons[i].name = items[i].name + "Button";
            buttons[i].item = items[i];
            buttons[i].GetComponent<RectTransform>().sizeDelta = new Vector2(buttons[i].GetComponent<RectTransform>().sizeDelta.x, buttonHeight);
            Vector2 buttonSize = buttons[i].GetComponent<RectTransform>().sizeDelta;
            Debug.Log(bounds.sizeDelta.y + " " + (bounds.sizeDelta.y - edge - i * buttonHeight - i * buttonSpace - items.Count * 10));
            buttons[i].transform.localPosition = new Vector2(-scrollBarWidth/2, bounds.sizeDelta.y/2 - buttonHeight/2 - edge - i*buttonHeight - i*buttonSpace);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
