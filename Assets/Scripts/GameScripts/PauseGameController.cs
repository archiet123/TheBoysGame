using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameController : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
    public GameObject player;
    //get ui active varible

    void Start()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        //if new variable true then avoid running this.
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
}

