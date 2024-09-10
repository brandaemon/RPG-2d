using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BigRobotBoss1 : MonoBehaviour
{
    public GameObject laser;
    public Transform LeftLaser;
    public Transform RightLaser;
    public GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Attack", 1f, 1f);
        player = GameObject.Find("Player");

        
    }

    // Update is called once per frame
   void Attack()
   {
        GameObject newLaser1 = Instantiate(laser, LeftLaser.position, LeftLaser.rotation);
        newLaser1.transform.right = player.transform.position - newLaser1.transform.position;
        //newLaser1.transform.rotation = Quaternion.Euler(newLaser1.transform.localEulerAngles.x, newLaser1.transform.localEulerAngles.y, newLaser1.transform.localEulerAngles.z);
        newLaser1.GetComponent<Rigidbody2D>().AddForce(10f * newLaser1.transform.right, ForceMode2D.Impulse);
        Instantiate(laser, RightLaser.position, RightLaser.rotation);
   }

   
}
