using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //UI   
    public GameObject pauseMenu;
    public GameObject player;
    public GameObject GunBenchUI;
    public GameObject OptionsMenu;

    //bools
    public static bool isPaused;
    [SerializeField] public static bool DisablePauseMenu = false;

    public void Update()
    {
        GetInput();
    }

    public void GetBool(bool IsShown)
    {
        DisablePauseMenu = IsShown;
    }

    private void GetInput()
    {

        if (!DisablePauseMenu)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused)
                {
                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            }
        }
        else if (DisablePauseMenu)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                GunBenchUI.SetActive(false);
                Time.timeScale = 1f;
                player.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                DisablePauseMenu = false;
                Debug.Log("close bench");
                FindObjectOfType<GunBenchScript>().GetBool(DisablePauseMenu);
            }
        }
        else
        {
            Debug.Log("error");
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isPaused = true;
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
}