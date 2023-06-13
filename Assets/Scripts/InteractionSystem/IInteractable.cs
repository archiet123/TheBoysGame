using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    void Interact(Transform InteractorTransform);
    string GetInteractText();

    Transform GetTransform();
}
