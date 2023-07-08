using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunbenchInteractable : MonoBehaviour, IInteractable
{
    public GameObject GunBenchUI;
    public GameObject player;
    public static bool IsShown;
    public PauseGameController UIToDisable;
    public bool DisablePause;
    void Start()
    {
        IsShown = false;
        UIToDisable = GameObject.Find("GameManager").GetComponent<PauseGameController>();
    }

    void Update()
    {
        // Debug.Log(DisablePause);
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
            // CloseGunbench();
            //not sure why this does not work
            //this is bad code
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
        DisablePause = false;
        UIToDisable.sendValue(DisablePause);
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
        DisablePause = true;
        UIToDisable.sendValue(DisablePause); //send your value to another script
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
