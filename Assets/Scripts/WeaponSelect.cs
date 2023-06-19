using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelect : MonoBehaviour
{
    public WeaponChoice[] weaponChoices;
    public GameObject ButtonParent;
    // public int i;    
    private void OnEnable()
    {
        for (int i = 0; i < 26; i++)
        {
            weaponChoices[i].gameObject.SetActive(true);
            weaponChoices[i].WeaponText.text = (i + 1).ToString();
        }

    }

    private void SelectedWeapon()
    {
        Debug.Log("selected weapon");
    }

}
