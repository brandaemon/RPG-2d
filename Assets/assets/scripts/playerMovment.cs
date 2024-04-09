using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    float horizontal;
    float vertical;
    public GameObject attack;
    public float offset;
    public int health;
    private bool facingRight = true;

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



        if (health <= 0)
        {
            print("You dead, L");
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
            health -= 1;
            print(health);
        }
    }

    void Flip()
    {
        print("flipping");
        Vector3 NewScale = transform.localScale;
        NewScale.x *= -1;
        transform.localScale = NewScale;

        facingRight = !facingRight;
    }
}
