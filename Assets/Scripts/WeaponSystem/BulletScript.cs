using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject Bullet;
    public int MaxCollisions;
    public int Collisions;
    private void Update()
    {
        if (Collisions > MaxCollisions)
        {
            Destroy();
        }
    }

    private void Start()
    {
        // Destroy(gameObject, 1.5f);
    }
    private void OnCollisionEnter(Collision Collision)
    {
        Collisions++;
    }
    private void Destroy()
    {
        Destroy(gameObject);

    }
}
