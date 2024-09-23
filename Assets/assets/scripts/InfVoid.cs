using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfVoid : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    private Animator animator;
    public float speed;
    public float followDistance;
    public float activeDistance;
    Transform player;
     float horizontal;
    float vertical;
    private bool facingRight = false;
    public GameObject explosion;
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


        if (Vector2.Distance(player.position, transform.position) <= 1.5f)
            {
                animator.SetTrigger("attack");
            }

        if (player.transform.position.x - transform.position.x >= 0f && facingRight == false)
            {
                Flip();
            }

        if (player.transform.position.x - transform.position.x <= 0f && facingRight == true)
            {
                Flip();
            }
        
        

            

        

        if (Vector2.Distance(player.position, transform.position) > followDistance && Vector2.Distance(player.position, transform.position) < activeDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


        

    }

    void OnTriggerEnter2D(Collider2D colision)     
    {
        
        if (colision.gameObject.CompareTag("Attack"))
        {
            print("attacked");
            //health -= colision.gameObject;
            print(health);
            
        }

        
        

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("FireBallT1"))
        {
            print("attacked");
            health -= 25;
            print(health);
            Destroy(col.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (col.gameObject.CompareTag("FireBallT1Left"))
        {
            print("attacked");
            health -= 25;
            print(health);
            Destroy(col.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (col.gameObject.CompareTag("BossLaser"))
        {
            print("attacked");
            health -= 25;
            print(health);
            Destroy(col.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
    
    void Flip()
    {
        Vector3 NewScale = transform.localScale;
        NewScale.x *= -1;
        transform.localScale = NewScale;

        facingRight = !facingRight;
    }
}
