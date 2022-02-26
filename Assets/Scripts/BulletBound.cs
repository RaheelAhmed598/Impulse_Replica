using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBound : MonoBehaviour
{
    // bullet dmg var
    public int damage;

    // bullet collide with enemy and destroy the enemy
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Particleeffects.Instance.InstantiateBulletEffects(other.transform);
            // get dmg
            other.GetComponent<Enemy>().damageEnemy(damage);
            Destroy(gameObject);
        }
    }
    private void destroyBullet()
    {
        // bullet destroy after killing the enemy  
        Destroy(gameObject);

    }
}
