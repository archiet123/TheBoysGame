using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int MaxCollisions;
    public int Collisions;
    private void Update()
    {
        if (Collision > MaxCollisions)
        {
            Destroy();
        }
    }

    private void OnCollisionEnter(Collision Collision)
    {
        Collisions++;
    }
    private void Destroy()
    {
        Destroy(CurrentBullet);
    }
}
