using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int EnemyHealth;
    public GameObject GameManager;


    void Update()
    {
        if (EnemyHealth <= 0)
        {
            gameObject.SetActive(false);
            // GameManager.GetComponent<GameStatus>();
        }
    }

    public void DealDamage(int WeaponDamage)
    {
        EnemyHealth = EnemyHealth - WeaponDamage;
        // Debug.Log($"{gameObject} Health: {EnemyHealth}");
    }
}
