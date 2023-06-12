using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private void Update()
    {
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
        float InteractRange = 2f;
        Collider[] ColliderArray = Physics.OverlapSphere(transform.position, InteractRange);
        foreach (Collider Collider in ColliderArray)
        {
            if (Collider.TryGetComponent(out NpcInteractable npcInteractable))
            {
                return npcInteractable;
            }
        }
        return null;
    }
}
