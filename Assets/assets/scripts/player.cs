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
    public int health;
    private bool facingRight = true;
    public float mana;
    public GameObject FireBallT1;
    public GameObject FireBallT1Left;
    public int timer;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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



        if (Input.GetMouseButtonDown(0) && facingRight == true)
            Instantiate(attack, transform.position + new Vector3(offset, 0f, 0f), attack.transform.rotation);

        if (Input.GetMouseButtonDown(0) && facingRight == false)
            Instantiate(attack, transform.position + new Vector3(-offset, 0f, 0f), attack.transform.rotation);





        if (Input.GetMouseButtonDown(1) && facingRight == true){
            if (mana >= 10){
              Instantiate(FireBallT1, transform.position + new Vector3(offset, 0f, 0f), FireBallT1.transform.rotation);
                print("fireball");
                mana -= 10;  
            }
            
        }

         if (Input.GetMouseButtonDown(1) && facingRight == false){
            if (mana >= 10){
              Instantiate(FireBallT1Left, transform.position + new Vector3(offset, 0f, 0f), FireBallT1Left.transform.rotation);
                print("fireball");
                mana -= 10;
            }
         
            
         }


        if (health <= 0)
        {
            print("You dead, L");
        }

        if (mana <= 100)
        {
           mana += 0.005f; 
        }
            
        if (mana >= 100)
        {
            mana = 100;
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


    void Flip()
    {
        Vector3 NewScale = transform.localScale;
        NewScale.x *= -1;
        transform.localScale = NewScale;

        facingRight = !facingRight;
    }

}
