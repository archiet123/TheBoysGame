using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerEnableUI : MonoBehaviour
{
    [SerializeField] private GameObject ContainerGameObject;
    [SerializeField] private PlayerInteract playerInteract;

    private void Update()
    {
        // var program = new Program();

        if (playerInteract.GetInteractableObject() != null)
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
