using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveChilderen : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            if (!gameObject.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                Debug.Log("win");
            }
        }
        // Debug.Log("loss");
    }
}
