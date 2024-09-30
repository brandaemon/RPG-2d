using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FireBall : MonoBehaviour
{

    public float speed; 
    public int timer;
    public player player;
    public bool facingRight;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.GetComponent<player>();
        }
        else
        {
            Debug.LogError("Player GameObject not found!");
        }

    }
     public void SetDirection(bool isFacingRight)
    {
        facingRight = isFacingRight;
    }
    // Update is called once per frame
    void Update()
    {
        if (facingRight == true){
            transform.Translate(Vector2.right * Time.deltaTime * speed);

                timer -= 1;
                if (timer <= 0){
                    Destroy(gameObject);
                }
        } else {
            transform.Translate(Vector2.right * Time.deltaTime * speed);

            timer -= 1;
            if (timer <= 0){
                Destroy(gameObject); 
            }
        }    
    }


    void OnCollisionEnter2D(Collision2D col){
    
        if (col.gameObject.CompareTag("BossLaser"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("TileMap"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    
    }
}
