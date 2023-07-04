using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HealthVariables
{
    public int DeadEnemyCount;

    void Update()
    {
        Debug.Log($"parent script: {DeadEnemyCount}");
    }
}
