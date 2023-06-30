using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health;


    void Update()
    {
        if (Health <= 0)
        {
            Debug.Log("you lose");
        }
    }

    public void DealDamage(int EnemyDamage)
    {
        Debug.Log("test");
        Health = Health - EnemyDamage;
        // Debug.Log($"{gameObject} Health: {Health}");
    }
}
