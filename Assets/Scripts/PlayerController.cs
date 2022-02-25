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

    void GetInput()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

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
        playerRb.MovePosition(playerRb.position + movement.normalized * (moveSpeed * Time.fixedDeltaTime));
    }

    private void LookAtObjects()
    {
        if (cam is null)
            return;
        var dir  = Input.mousePosition - cam.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }




}
