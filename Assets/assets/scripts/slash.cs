using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slash : MonoBehaviour
{
    public int timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 10;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;
        if (timer <= 0)
            Destroy(gameObject);
    }
}
