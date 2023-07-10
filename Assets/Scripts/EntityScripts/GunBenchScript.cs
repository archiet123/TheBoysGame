using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBenchScript : MonoBehaviour, IInteractable
{
    //GameObjects
    public GameObject player;
    public GameObject GunBenchUI;
    //bools
    [SerializeField] public static bool IsShown = false;

    void Update()
    {
        Debug.Log($"gunbenchscript (Isshown): {IsShown}");
    }
    public void GetBool(bool DisablePauseMenu)
    {
        //IsShown is on this script
        IsShown = DisablePauseMenu;
    }

    public void ShootingBool(bool DisableShooting)
    {
        IsShown = DisableShooting;
    }

    public void EnableClose(bool CloseUI)
    {
        IsShown = CloseUI;
    }

    private void ToggleBenchUI()
    {
        //updating variable for status of GunBenchUI
        FindObjectOfType<UIController>().GetBool(IsShown);
        if (!IsShown)
        {
            //this opens the UI when E is clicked annd IsShown is false
            OpenGunbench();
            // Debug.Log("open bench");
            FindObjectOfType<UIController>().GetBool(IsShown);


        }
        else
        {
            //this closes the UI when E is clicked annd IsShown is true
            CloseGunbench();
            // Debug.Log("close bench");
            FindObjectOfType<UIController>().GetBool(IsShown);
            // Debug.Log("enable shooting");
            FindObjectOfType<GunScript>().StartShooting1(IsShown);

        }
    }
    public void CloseGunbench()
    {
        // Debug.Log("close");
        GunBenchUI.SetActive(false);
        Time.timeScale = 1f;
        IsShown = false;
        // FindObjectOfType<GunScript>().GetBool(IsShown);
        player.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        IsShown = false;
    }

    public void OpenGunbench()
    {
        // Debug.Log("open");
        GunBenchUI.SetActive(true);
        Time.timeScale = 0f;
        IsShown = true;
        // FindObjectOfType<GunScript>().GetBool(IsShown);
        // player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    public void UseGunBench()
    {
        // Debug.Log("Bench Toggled");
        ToggleBenchUI();
    }

    //Interactable stuff for gun bench
    //↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓

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