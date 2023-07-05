using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayOptions : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject OptionsMenu;

    public void ShowOptions()
    {
        PauseMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void HideOptions()
    {
        OptionsMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }
}
