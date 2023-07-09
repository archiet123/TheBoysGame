using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBenchScript : MonoBehaviour, IInteractable
{
    //GameObjects
    public GameObject player;
    public GameObject GunBenchUI;
    public UIController RecipientScript;


    //bools
    public static bool IsShown = false;

    void Start()
    {
        RecipientScript = GameObject.Find("GameManger").GetComponent<UIController>();
    }

    void Update()
    {
        // Debug.Log($"should be false: {IsShown}");
    }

    private void ToggleBenchUI()
    {
        // Debug.Log("got input");
        IsShown = !IsShown;
        if (IsShown)
        {
            // Debug.Log("open");
            OpenGunbench();
            RecipientScript.GetBool(IsShown); //send your value to another script
        }
        else
        {
            // Debug.Log("close");
            CloseGunbench();
        }
    }
    public void CloseGunbench()
    {

        GunBenchUI.SetActive(false);
        Time.timeScale = 1f;
        IsShown = false;
        player.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void OpenGunbench()
    {

        GunBenchUI.SetActive(true);
        Time.timeScale = 0f;
        IsShown = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    public void UseGunBench()
    {
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
