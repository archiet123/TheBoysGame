using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : ActiveChilderen
{
    public int EnemyHealth;
    public GameObject GameManager;

    void Update()
    {
        CheckEnemyHealth();
    }

    public void CheckEnemyHealth()
    {
        if (EnemyHealth <= 0)
        {
            gameObject.SetActive(false);
            DeadEnemyCount++;
            Debug.Log($"enemy script: {DeadEnemyCount}");
        }
    }

    public void DealDamage(int WeaponDamage)
    {
        EnemyHealth = EnemyHealth - WeaponDamage;
        // Debug.Log($"{gameObject} Health: {EnemyHealth}");
    }
}
