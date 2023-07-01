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
        Debug.Log(ChildCount);
    }
    public void CheckLevel()
    {

    }

}
