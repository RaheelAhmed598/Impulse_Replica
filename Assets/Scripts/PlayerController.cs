using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Camera cam;
    public Rigidbody2D playerRb;
    private Vector2 movement;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        playerRb = GetComponent<Rigidbody2D>();
    }

    //get input (Arrows Keys & WASD keys)
    void GetInput()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    // If enemy collide with the player, player dies
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        LookAtObjects();
    }

    private void FixedUpdate()
    {
        Move();    
    }

    void Move()
    {
        // player movement using physics (Rigidbody)
        playerRb.MovePosition(playerRb.position + movement.normalized * (moveSpeed * Time.fixedDeltaTime));
    }

    private void LookAtObjects()
    {
        if (cam is null)
            return;
        //Transforms position from world space into screen space.
        var dir  = Input.mousePosition - cam.WorldToScreenPoint(transform.position);
        //Return value is the angle between the x-axis and a 2D vector starting at zero and terminating at (x,y).
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
        //Creates a rotation which rotates angle degrees around axis.
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }




}
