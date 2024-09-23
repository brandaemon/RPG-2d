using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    float horizontal;
    float vertical;
    public GameObject attack;
    public float offset;
    public float health;
    public bool facingRight = true;
    public float mana;
    public GameObject FireBallT1;
    public GameObject FireBallT1Left;
    public int timer;
    private Animator animator;
    private Invintory invintory;
    public item item;
    public GameObject explosion;
        



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        invintory = GameObject.Find("Inventory Manager").GetComponent<Invintory>();
            
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


        if (horizontal < 0.0f && facingRight == true)
        {
            Flip();
        }
            
        if (horizontal > 0.0f && facingRight == false)
        {
            Flip();
        }



        if (Input.GetMouseButtonDown(0) && facingRight == true && invintory.paused == false)
            Instantiate(item.attackAnimation, transform.position + new Vector3(offset, 0f, 0f), attack.transform.rotation);

        if (Input.GetMouseButtonDown(0) && facingRight == false && invintory.paused == false)
            Instantiate(item.attackAnimation, transform.position + new Vector3(-offset, 0f, 0f), attack.transform.rotation);





        if (Input.GetMouseButtonDown(1) && facingRight == true){
            if (mana >= 10){
                GameObject fireball = Instantiate(FireBallT1, transform.position + new Vector3(offset, 0f, 0f), FireBallT1.transform.rotation);
                fireball.GetComponent<FireBall>().SetDirection(facingRight);
                print("fireball");
                mana -= 10;  
            }
                
        }

        if (Input.GetMouseButtonDown(1) && facingRight == false){
            if (mana >= 10){
                GameObject fireball = Instantiate(FireBallT1Left, transform.position + new Vector3(-offset, 0f, 0f), FireBallT1Left.transform.rotation);
                fireball.GetComponent<FireBall>().SetDirection(facingRight);
                print("fireball");
                    
                mana -= 10;
            }
            
                
        }


        if (health <= 0)
        {
            print("You dead, L");
        }

        if (health <= 100)
        {
            health += 0.005f;
        }

        if (mana <= 100)
        {
        mana += 0.005f; 
        }
                
        if (mana >= 100)
        {
            mana = 100;
        }

        if (mana <= 0)
        {
            mana = 1;
        }

            
        if (Input.GetKeyDown("e"))
        {
            //animator.ResetTrigger("dance");
            animator.SetTrigger("dance");   
        }

        
            

            

        
            

    }

    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rb.MovePosition(position);






    }

    void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.CompareTag("InfVAttack"))
        {
            health -= 5;
            print(health);
        }

        if (colision.gameObject.CompareTag("ManaCrystal1"))
        {
            mana += 50;
            Destroy(colision.gameObject);
        }

        

        
            
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("BossLaser"))
        {
            health -= 25;
            Destroy(col.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);

            if (col.gameObject.CompareTag("sword")) 
        {
            invintory.hassword = true;
            Destroy(col .gameObject);
        }
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
