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
        //DisablePauseMenu is on this script
        DisablePauseMenu = IsShown;
    }

    public void ShootingBool(bool DisableShooting)
    {
        DisablePauseMenu = DisableShooting;
    }

    private void GetInput()
    {

        if (!DisablePauseMenu)
        {
            //if false the pause menu will be displayed
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
            //this closes the UI when Escape is clicked annd DisablePauseMenu is true
            //if true the gunbenchUI will be hidden
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                GunBenchUI.SetActive(false);
                Time.timeScale = 1f;
                player.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                DisablePauseMenu = false;
                // getting variable from GunBenchScript
                FindObjectOfType<GunBenchScript>().GetBool(DisablePauseMenu);
                // Debug.Log("enable shooting");
                FindObjectOfType<GunScript>().StartShooting(DisablePauseMenu);

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

    public void DisplayOptionsMenu()
    {
        pauseMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void HideOptionsMenu()
    {
        pauseMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }
}