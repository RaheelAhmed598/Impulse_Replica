using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBound : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Particleeffects.Instance.InstantiateBulletEffects(other.transform);
            //damage
            other.GetComponent<Enemy>().damageEnemy(damage);
            Destroy(gameObject);
        }
    }
    private void destroyBullet()
    {
        Destroy(gameObject);

    }
}
