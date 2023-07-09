using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBenchScript : MonoBehaviour, IInteractable
{
    //this script is to be the gun bench interactable
    public GameObject player;
    public GameObject GunBenchUI;
    public static bool IsShown = false;

    void Update()
    {
        Debug.Log(IsShown);
    }
    private void ToggleBenchUI()
    {
        Debug.Log("got input");
        IsShown = !IsShown;
        if (IsShown)
        {
            Debug.Log("open");
            OpenGunbench();
        }
        else
        {
            Debug.Log("close");
            CloseGunbench();
        }
    }
    public void CloseGunbench()
    {
        // Debug.Log("close");
        GunBenchUI.SetActive(false);
        Time.timeScale = 1f;
        IsShown = false;
        player.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void OpenGunbench()
    {
        // Debug.Log("open");
        GunBenchUI.SetActive(true);
        Time.timeScale = 0f;
        IsShown = true;
        // player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    public void UseGunBench()
    {
        Debug.Log("Bench Toggled");
        ToggleBenchUI();
    }


    public string GetInteractText()
    {
        return "Use Gunbench";
    }

    void IInteractable.Interact(Transform InteractorTransform)
    {
        UseGunBench();
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
