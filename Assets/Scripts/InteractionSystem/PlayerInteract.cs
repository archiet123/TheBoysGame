using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private void Update()
    {
        //if E is clicked within range on an entity NpcInteracable is called, 
        //functionality for that entity is run on NpcInteractable.
        if (Input.GetKeyDown(KeyCode.E))
        {
            IInteractable interactable = GetInteractableObject();
            if (interactable != null)
            {
                interactable.Interact(transform);
            }
            // float InteractRange = 2f;
            // Collider[] ColliderArray = Physics.OverlapSphere(transform.position, InteractRange);
            // foreach (Collider Collider in ColliderArray)
            // {
            //     if (Collider.TryGetComponent(out IInteractable interactable))
            //     {
            //         interactable.Interact(transform);
            //     }
            // }
        }

    }

    public IInteractable GetInteractableObject()
    {
        //script for displaying interaction prompt, also checking for closest possible entity
        float InteractRange = 4f;
        List<IInteractable> interactableList = new List<IInteractable>();
        Collider[] ColliderArray = Physics.OverlapSphere(transform.position, InteractRange);
        foreach (Collider Collider in ColliderArray)
        {
            if (Collider.TryGetComponent(out IInteractable interactable))
            {
                interactableList.Add(interactable);
                // return npcInteractable;
            }
        }
        IInteractable closestInteractable = null;
        foreach (IInteractable interactable in interactableList)
        {
            if (closestInteractable == null)
            {
                closestInteractable = interactable;
            }
            else
            {
                if (Vector3.Distance(transform.position, interactable.GetTransform().position) <
                    Vector3.Distance(transform.position, closestInteractable.GetTransform().position))
                {
                    //closest interactable.
                    closestInteractable = interactable;
                }
            }
        }

        return null;
    }
}
