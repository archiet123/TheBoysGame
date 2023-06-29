using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject Bullet;
    public int MaxCollisions;
    public int Collisions;
    public int WeaponDamage;
    public GameObject Enemies;
    string EnemyName;


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

        if (Collision.gameObject.tag == "Enemy")
        {

            EnemyName = Collision.gameObject.name;
            Debug.Log("collided with" + EnemyName);
            // Enemies.GetComponent<HealthScript>().DealDamage(WeaponDamage);
        }
    }
    private void Destroy()
    {
        Destroy(gameObject);

    }
}
