using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core;
using UnityEngine;
using UnityEngine.Animations;
using TMPro;

public class PlayerEnableUI : MonoBehaviour
{
    [SerializeField] private GameObject ContainerGameObject;
    [SerializeField] private PlayerInteract playerInteract;
    [SerializeField] private TextMeshProUGUI interactTextMeshProUGUI;


    private void Update()
    {
        //if null interaction prompt will be displayed
        if (playerInteract.GetInteractableObject() != null)
        {
            Show(playerInteract.GetInteractableObject());
        }
        else
        {
            Hide();
        }
    }

    private void Show(IInteractable interactable)
    {
        ContainerGameObject.SetActive(true);
        interactTextMeshProUGUI.text = interactable.GetInteractText();
    }

    private void Hide()
    {
        ContainerGameObject.SetActive(false);
    }


}
