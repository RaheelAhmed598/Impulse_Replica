using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform fire;

    public float force = 15f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
        {
            BulletFire();
        }
    }

     private void BulletFire()
    {
        var bullet = Instantiate(bulletPrefab, fire.position, fire.rotation);
        var rigidbody2D = bullet.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(fire.up * force, ForceMode2D.Impulse);
    }



}
