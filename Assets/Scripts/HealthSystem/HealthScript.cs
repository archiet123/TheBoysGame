using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    // public GameObject Enemies;
    public int EnemyHealth;


    void Update()
    {
        if (EnemyHealth < 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void DealDamage(int WeaponDamage)
    {
        EnemyHealth - int WeaponDamage;
    }
}
