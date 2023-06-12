using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteractable : MonoBehaviour
{
    public string NpcName;

    public void Interact()
    {
        Debug.Log($"Interact with {NpcName}");
        //dialouge stuff to go here
    }
}
