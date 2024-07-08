using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invintory : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject inventoryimage;
    public GameObject slotc1;
    public GameObject slotg1;

    public Sprite swordimage;
    
    public bool paused = false;
    public bool hassword = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("y"))
        {
            if (!paused) 
            
            {
                Time.timeScale = 0.0f;
                paused = true;
                inventoryimage.SetActive(true);
                if (hassword == true)
                {
                    //slotg1.GetComponent<Image>().sprite = swordimage;
                }
            }else{
                Time.timeScale = 1;
                paused = false;
                inventoryimage.SetActive(false);
            }

        }



    }
}
