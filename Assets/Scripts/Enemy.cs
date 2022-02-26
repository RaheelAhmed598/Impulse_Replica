using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public float speed;
    //private Rigidbody2D enemyRb;
    //private GameObject player;
    //private float Increase = 0.5f;

    // enemy health, speed (max and min)
    public int health;
    public Transform player;
    public float speed;
    private float maxSpeed = 2;
    private float minSpeed = 0.6f;

    
    // Start is called before the first frame update
    void Start()
    {
        // enemy find player using tag with speed (Min and max)
        player = GameObject.FindGameObjectWithTag("Player").transform;
        speed = Random.Range(maxSpeed, minSpeed);

        //enemyRb = GetComponent<Rigidbody2D>();
        //player = GameObject.Find("Player");
    }

    // Enemy Health after health than equal to 0 enemy die
    public void damageEnemy(int damageTaken)
    {
        health -= damageTaken;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    { 
        //Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        //enemyRb.AddForce(lookDirection * speed);
        //if (transform.position.y < -10)
        //{
        //    player.transform.localScale += new Vector3(Increase, Increase, Increase);
        //    player.GetComponent<Renderer>().material = Mats[Random.Range(0, Mats.Count)];
        //    Destroy(gameObject);
        //}
    }
}
