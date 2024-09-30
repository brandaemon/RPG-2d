using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLaser : MonoBehaviour
{

    public GameObject explosion;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("TileMap"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("BossLaser"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }

         if (col.gameObject.CompareTag("FireBallT1"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        
    }
}
