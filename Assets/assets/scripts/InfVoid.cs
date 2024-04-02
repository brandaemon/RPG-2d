using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfVoid : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
            Destroy(gameObject);

        if (Input.GetKeyDown("e"))
        {
            animator.SetTrigger("attack");
        }


    }

    void OnTriggerEnter2D(Collider2D colision)     
    {
        /*
        if (colision.gameObject.CompareTag("Player"))
        {
            health -= 1;
            print(health);
        }
        */
        if (colision.gameObject.CompareTag("Attack"))
        {
            print("attacked");
            health -= 1;
            print(health);
        }
        

    }
    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        print("attacked");
        if (col.gameObject.CompareTag("Attack"))
        {
            print("attacked");
        }
    }
    */
}
