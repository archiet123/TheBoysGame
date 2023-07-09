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
    public static bool isPaused = false;


    void Start()
    {

    }

    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Debug.Log("got input");
            if (isPaused)
            {
                // Debug.Log("resume");
                ResumeGame();
            }
            else
            {
                // Debug.Log("pause");
                PauseGame();
            }
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
