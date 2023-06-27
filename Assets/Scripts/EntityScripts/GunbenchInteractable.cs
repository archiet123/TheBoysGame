using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunbenchInteractable : MonoBehaviour, IInteractable
{
    public GameObject GunBenchUI;
    public GameObject player;
    public static bool IsShown;

    void Start()
    {
        IsShown = false;
        // GunBenchUI.SetActive(false);
    }

    private void ToggleBenchUI()
    {
        IsShown = !IsShown;
        if (IsShown)
        {
            OpenGunbench();
        }
        else
        {
            CloseGunbench();
        }
    }
    public void UseGunBench()
    {
        // Debug.Log("Bench Toggled");
        ToggleBenchUI();
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
        player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
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
