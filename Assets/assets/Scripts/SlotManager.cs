using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotManager : MonoBehaviour, IPointerClickHandler 
{
    public item item;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().sprite = item.icon;
        Color TMP = gameObject.GetComponent<Image>().color;
        TMP.a = 1f;
        gameObject.GetComponent<Image>().color = TMP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateImage()
    {
        gameObject.GetComponent<Image>().sprite = item.icon;
        Color TMP = gameObject.GetComponent<Image>().color;
        TMP.a = 1f;
        gameObject.GetComponent<Image>().color = TMP;

    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log(name + " Game Object Clicked!");
    }

}
