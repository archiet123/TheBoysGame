using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : HealthVariables
{
    public int EnemyHealth;
    public GameObject GameManager;
    // public int DeadEnemyCount;
    void Update()
    {
        if (EnemyHealth <= 0)
        {
            gameObject.SetActive(false);
            DeadEnemyCount = DeadEnemyCount + 1;
            Debug.Log($"enemy script: {DeadEnemyCount}");
        }
    }

    public void DealDamage(int WeaponDamage)
    {
        EnemyHealth = EnemyHealth - WeaponDamage;
        // Debug.Log($"{gameObject} Health: {EnemyHealth}");
    }
}
