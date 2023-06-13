using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteractable : MonoBehaviour
{
    [SerializeField] private string InteractText;

    public string NpcName;

    public void Interact()
    {
        Debug.Log($"Interacted with {NpcName}");
        //dialouge stuff to go here
    }

    //returns objects or npcs interact text
    public string GetInteractText()
    {
        return InteractText;
    }
}
