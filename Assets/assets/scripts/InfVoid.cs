using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfVoid : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    private Animator animator;
    public float speed;
    public float followDistace;
    Transform player;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
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

        if (Vector2.Distance <= 1)
            {
                animator.SetTrigger("attack");
            }

        

        if (Vector2.Distance(player.position, transform.position) > followDistace)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed);
            
            
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
