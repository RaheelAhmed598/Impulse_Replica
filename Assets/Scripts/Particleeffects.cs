using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particleeffects : MonoBehaviour
{
    public GameObject bulletEffects;
    public static Particleeffects Instance;
    
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    // particle efect (duration and instantiate)
    public void InstantiateBulletEffects(Transform others)
    {
        var temp = Instantiate(bulletEffects, others.transform.position, Quaternion.identity);
        Destroy(temp, 0.5f);
    }
}
