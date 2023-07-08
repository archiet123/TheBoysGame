using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBenchScript : GunbenchInteractable
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            HideUI();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            // HideUI();
        }
    }

    public void HideUI()
    {
        GunBenchUI.SetActive(false);
        Time.timeScale = 1f;
        player.SetActive(true);
        IsShown = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        DisablePause = true;
        UIToDisable.sendValue(DisablePause);
    }
}
