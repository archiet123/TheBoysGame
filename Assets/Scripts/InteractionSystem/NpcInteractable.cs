using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string InteractText;

    public string NpcName;

    public void Interact()
    {
        Debug.Log($"Interacted with {NpcName}");
        // Debug.Log("got name");
        //dialouge stuff to go here
    }

    //returns objects or npcs interact text
    public string GetInteractText()
    {
        return InteractText;
    }

    public void Interact(Transform InteractorTransform)
    {
        // Debug.Log("test interact");
        Interact();
    }

    public Transform GetTransform()
    {
        // Debug.Log("got transform for derick");
        return transform;
    }
}
