using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ActiveChilderen : MonoBehaviour
{

    int ChildCount;
    int ActiveCount;
    public int DeadEnemyCount;
    void Start()
    {
        ChildCount = transform.childCount;
        // Debug.Log($"amount of enemies: {ChildCount}");
    }
    public void CheckLevel()
    {
        Debug.Log(DeadEnemyCount);
    }

}
