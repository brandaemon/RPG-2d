using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotManager : MonoBehaviour, IPointerClickHandler, IDropHandler
{
    public item item;
    
    // Start is called before the first frame update
    void Start()
    {
        if ( item != null){
            gameObject.GetComponent<Image>().sprite = item.icon;
            Color TMP = gameObject.GetComponent<Image>().color;
            TMP.a = 1f;
            gameObject.GetComponent<Image>().color = TMP; 
        }
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

    public void OnDrop(PointerEventData pointerEventData)
    {
        if (pointerEventData.pointerDrag != null)
        {
            item swp = item;
            item = pointerEventData.pointerDrag.GetComponent<SlotManager>().item;
            pointerEventData.pointerDrag.GetComponent<SlotManager>().item = swp;
            pointerEventData.pointerDrag.GetComponent<SlotManager>().updateImage();

            print("hello!");
            updateImage();
        }
    }

}
