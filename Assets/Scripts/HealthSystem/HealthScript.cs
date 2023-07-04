using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int EnemyHealth;
    public int DeadEnemyCount;
    public ActiveChilderen anotherScript;
    void Update()
    {
        CheckEnemyHealth();
    }

    void Start()
    {
        anotherScript = GameObject.Find("Enemies").GetComponent<ActiveChilderen>();
    }

    public void CheckEnemyHealth()
    {
        if (EnemyHealth <= 0)
        {
            gameObject.SetActive(false);
            DeadEnemyCount++;
            // Debug.Log($"enemy script: {DeadEnemyCount}");
            anotherScript.sendValue(DeadEnemyCount); //send your value to another script

        }
    }

    public void DealDamage(int WeaponDamage)
    {
        EnemyHealth = EnemyHealth - WeaponDamage;
        // Debug.Log($"{gameObject} Health: {EnemyHealth}");
    }
}
