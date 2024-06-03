using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invintory : MonoBehaviour
{
    // Start is called before the first frame update

    public bool paused = false;
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
            }else{
                Time.timeScale = 1;
                paused = false;
            }
        }
    }
}
