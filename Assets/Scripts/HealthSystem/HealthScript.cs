using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public int EnemyHealth;
    public int DeadEnemyCount;
    public ActiveChilderen anotherScript;

    //UI Objects
    public Slider HealthSlider;
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

    public void SetHealth(int CurrentHealth)
    {
        Debug.Log("sethealth");
        HealthSlider.value = CurrentHealth;
    }

    public void DealDamage(int WeaponDamage)
    {
        EnemyHealth = EnemyHealth - WeaponDamage;
        SetHealth(EnemyHealth);
    }
}
