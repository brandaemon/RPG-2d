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

        
        if (horizontal < 0.0f)
        {
            //transform.localScale.x *= -1;
        }
        


        if (Input.GetMouseButtonDown(0))
            Instantiate(attack, transform.position+new Vector3(offset,0f, 0f), attack.transform.rotation);

    }

    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rb.MovePosition(position);
    }   
}
