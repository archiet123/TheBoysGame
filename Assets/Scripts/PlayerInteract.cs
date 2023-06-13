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
            float InteractRange = 2f;
            Collider[] ColliderArray = Physics.OverlapSphere(transform.position, InteractRange);
            foreach (Collider Collider in ColliderArray)
            {
                if (Collider.TryGetComponent(out NpcInteractable npcInteractable))
                {
                    npcInteractable.Interact();
                }
            }
        }

    }

    public NpcInteractable GetInteractableObject()
    {
        //script for displaying interaction prompt, also checking for closest possible entity
        float InteractRange = 4f;
        List<NpcInteractable> npcInteractableList = new List<NpcInteractable>();
        Collider[] ColliderArray = Physics.OverlapSphere(transform.position, InteractRange);
        foreach (Collider Collider in ColliderArray)
        {
            if (Collider.TryGetComponent(out NpcInteractable npcInteractable))
            {
                npcInteractableList.Add(npcInteractable);
                return npcInteractable;
            }
        }
        NpcInteractable closestNpcInteractable = null;
        foreach (NpcInteractable npcInteractable in npcInteractableList)
        {
            if (closestNpcInteractable == null)
            {
                closestNpcInteractable = npcInteractable;
            }
            else
            {
                if (Vector3.Distance(transform.position, npcInteractable.transform.position) <
                    Vector3.Distance(transform.position, closestNpcInteractable.transform.position))
                {
                    //closest interactable.
                    closestNpcInteractable = npcInteractable;
                }
            }
        }

        return null;
    }
}
