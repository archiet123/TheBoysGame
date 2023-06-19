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
    }

    private void HideUI()
    {
        GunBenchUI.SetActive(false);
        Time.timeScale = 1f;
        player.SetActive(true);
        IsShown = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
