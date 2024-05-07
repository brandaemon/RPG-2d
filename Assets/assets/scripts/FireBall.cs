using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FireBall : MonoBehaviour
{

    public float speed; 
    public int timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);

        timer -= 1;
        if (timer <= 0)
            Destroy(gameObject);
    }


    
}
