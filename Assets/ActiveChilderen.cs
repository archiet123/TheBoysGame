using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveChilderen : MonoBehaviour
{
    public void CheckLevel()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            if (!gameObject.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                Debug.Log("empty??");
            }
        }
        // Debug.Log("not empty??");
    }
}
