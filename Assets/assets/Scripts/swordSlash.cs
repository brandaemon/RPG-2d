using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordSlash : MonoBehaviour
{
    public int timer;
    public int damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        //timer = 10;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;
        if (timer <= 0)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Infvoid"))
        {
            collision.gameObject.GetComponent<InfVoid>().health -= 20;
            print("massive damage");
        }

        
    }
}
