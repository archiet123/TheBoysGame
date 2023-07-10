using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health;
    public GameObject GameManager;


    void Update()
    {
        if (Health <= 0)
        {
            Debug.Log("you lose");
            GameManager.GetComponent<UIController>().DisplayLoseScreen();
        }
    }

    public void DealDamage(int EnemyDamage)
    {
        // Debug.Log("test");
        Health = Health - EnemyDamage;

    }
}
