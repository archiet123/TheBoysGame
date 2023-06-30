using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject Bullet;
    public int MaxCollisions;
    public int Collisions;
    public int WeaponDamage;
    public GameObject RedEnemy;
    string GetName;


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
        GameObject other = Collision.gameObject;
        Collisions++;
        // Debug.Log("collided with" + Collision.gameObject.name); checking to see what the bullet actually collides with
        if (Collision.gameObject.tag == "Enemy")
        {
            //get the name of the gameobject the bullet collided with and call the function DealDamage on the,
            //gameobjects script
            GetName = Collision.gameObject.name;
            // EnemyName = new GameObject(GetName);
            // Debug.Log("collided with " + EnemyName);
            other.GetComponent<HealthScript>().DealDamage(WeaponDamage);

        }
    }
    private void Destroy()
    {
        Destroy(gameObject);

    }
}
