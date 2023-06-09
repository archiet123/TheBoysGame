using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    int countDownStartValue = 3;
    public int EnemyHealth;
    public int DeadEnemyCount;
    public ActiveChilderen anotherScript;

    //UI Objects
    public Slider HealthSlider;
    public GameObject EnemyHealthBar;
    void Update()
    {
        CheckEnemyHealth();
    }

    void Start()
    {
        EnemyHealthBar.SetActive(false);
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
        // Debug.Log("sethealth");
        HealthSlider.value = CurrentHealth;
    }

    public void DealDamage(int WeaponDamage)
    {
        EnemyHealth = EnemyHealth - WeaponDamage;
        countDownTimer();
        EnemyHealthBar.SetActive(true);
        SetHealth(EnemyHealth);
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            EnemyHealthBar.SetActive(false);
        }
    }
}
