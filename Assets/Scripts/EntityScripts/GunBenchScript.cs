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
    // [SerializeField] public static bool CanShoot;

    public void GetBool(bool DisablePauseMenu)
    {
        IsShown = DisablePauseMenu;
    }

    private void ToggleBenchUI()
    {
        //updating variable for status of GunBenchUI
        FindObjectOfType<UIController>().GetBool(IsShown);
        if (!IsShown)
        {
            OpenGunbench();
            // Debug.Log("open bench");
            FindObjectOfType<UIController>().GetBool(IsShown);
            //is true
            FindObjectOfType<GunScript>().GetBool(IsShown);
        }
        else
        {
            CloseGunbench();
            // Debug.Log("close bench");
            FindObjectOfType<UIController>().GetBool(IsShown);
            //is false
            FindObjectOfType<GunScript>().GetBool(IsShown);
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
        IsShown = false;
    }

    public void OpenGunbench()
    {
        // Debug.Log("open");
        GunBenchUI.SetActive(true);
        Time.timeScale = 0f;
        IsShown = true;
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