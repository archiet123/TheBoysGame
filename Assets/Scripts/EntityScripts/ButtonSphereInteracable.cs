using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSphereInteracable : MonoBehaviour, IInteractable
{
    [SerializeField] private MeshRenderer SphereMeshRenderer;
    [SerializeField] private Material SilverMaterial;
    [SerializeField] private Material GoldMaterial;

    private bool IsGold;

    private void SetColourSilver()
    {
        SphereMeshRenderer.material = SilverMaterial;
    }

    private void SetColourGold()
    {
        SphereMeshRenderer.material = GoldMaterial;
    }

    private void ToggleColour()
    {
        IsGold = !IsGold;
        if (IsGold)
        {
            SetColourGold();
        }
        else
        {
            SetColourSilver();
        }
    }

    public void PushButton()
    {
        ToggleColour();
    }

    public string GetInteractText()
    {
        return "Push button";
    }

    void IInteractable.Interact(Transform InteractorTransform)
    {
        PushButton();
    }

    public Transform GetTransform()
    {
        // Debug.Log("got transform");
        return transform;
    }
}
