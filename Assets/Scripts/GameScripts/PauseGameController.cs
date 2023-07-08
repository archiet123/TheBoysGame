using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameController : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
    public GameObject player;
    public bool DisablePause;

    //need to be static
    //this will receive variable
    public static ActiveChilderen DisableUI;

    void Start()
    {
        isPaused = false;
        pauseMenu.SetActive(false);

        if (DisableUI == null)
        {
            DisableUI = new ActiveChilderen();
        }
    }

    void Update()
    {
        sendValue(DisablePause);
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

    public void sendValue(bool DisablePause)
    {
        // if new variable true then avoid running this.
        if (DisablePause)
        {
            Debug.Log("DisablePause");
        }
        else
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

    }
}


