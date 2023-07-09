using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour, IInteractable
{

    //UI
    public GameObject pauseMenu;
    public GameObject player;
    public GameObject GunBenchUI;
    public GameObject OptionsMenu;

    //gameobjects
    public Button BackButton;

    //bools
    public bool DisablePause;
    public static bool isPaused = false;
    public static bool IsShown;

    void Start()
    {
        // pauseMenu.SetActive(false);
        IsShown = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Debug.Log("resume");
                ResumeGame();
            }
            else
            {
                Debug.Log("pause");
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        player.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
            //not sure why this does not work
            //this is bad code
        }
    }
    public void UseGunBench()
    {
        // Debug.Log("Bench Toggled");
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
    }
}
