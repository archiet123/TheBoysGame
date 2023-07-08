using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public class DisplayOptions : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject OptionsMenu;
    public Button BackButton;
    public GameObject player;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            // BackButton.onClick.Invoke();
            // var eventSystem = EventSystem.current;//setting event system
            // ExecuteEvents.Execute(BackButton.gameObject, new BaseEventData(eventSystem), ExecuteEvents.submitHandler);
            HideOptions();
        }
    }

    public void ShowOptions()
    {
        PauseMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void HideOptions()
    {
        OptionsMenu.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
