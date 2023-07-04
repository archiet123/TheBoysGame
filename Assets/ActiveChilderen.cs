using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ActiveChilderen : MonoBehaviour
{

    int ChildCount;
    public int ActiveCount;

    //need to be static
    public static ActiveChilderen Current;

    void Start()
    {
        ChildCount = transform.childCount;
        // Debug.Log($"amount of enemies: {ChildCount}");

        if (Current == null)
        {
            Current = new ActiveChilderen();
        }
    }

    public void sendValue(int val)
    {
        ActiveCount = ActiveCount + val;
    }

    public void CheckLevel()
    {
        if (ChildCount == ActiveCount)
        {
            // Debug.Log("you win");
            // return true;
        }
    }

}
