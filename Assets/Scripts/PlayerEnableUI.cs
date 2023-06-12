using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerEnableUI : MonoBehaviour
{
    [SerializeField] private GameObject ContainerGameObject;
    [SerializeField] private PlayerInteract playerInteract;

    private void Update()
    {
        if (PlayerInteract.GetInteractableObject() != null)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        ContainerGameObject.SetActive(true);
    }

    private void Hide()
    {
        ContainerGameObject.SetActive(false);
    }
}
