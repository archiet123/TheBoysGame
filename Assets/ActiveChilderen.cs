using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ActiveChilderen : MonoBehaviour
{

    int ChildCount;
    int ActiveCount;

    void Start()
    {
        ChildCount = transform.childCount;
        // Debug.Log($"amount of enemies: {ChildCount}");
    }
    public void CheckLevel()
    {
        int Count = gameObject.GetComponent<HealthVariables>().DeadEnemyCount;
        // GameObject.Find("nameOfObjectYourScriptIsOn").GetComponent<move>().speed
        // Debug.Log(Count);
    }

}
