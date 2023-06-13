using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    void Interact(Transform IntoractorTransform);
    string GetInteractText();

    Transform GetTransform();
}
