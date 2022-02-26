using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : Enemy
{
    // AI chase system with enemy to player
    public float stopDistance;

    private void Update()
    {
        if (player != null)
        {
            if (Vector2.Distance(transform.position, player.position)> stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed*Time.deltaTime );
            }
        }
    }
}
