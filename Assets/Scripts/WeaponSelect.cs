using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelect : MonoBehaviour
{
    public WeaponChoice[] weaponChoices;
    public GameObject ButtonParent;

    // private void OnEnable()
    // {
    //     for (int i = 0; i < GameManager.Instance.weaponCounts[GameManager.Instance.currentWeapon]; i++)
    //     {
    //         int WeaponNum = i + 1;
    //         weaponChoices[i].gameObject.SetActive(true);
    //         weaponChoices[i].WeaponText.text = (i + 1).ToString();
    //         weaponChoices[i].GetComponent<Button>().onClick.RemoveAllListeners();
    //         weaponChoices[i].GetComponent<Button>().onClick.AddListener(() => SelectWeapon(GameManager.Instance.currentWeapon, WeaponNum));
    //     }
    // }

    private void SelectWeapon(int Weapon, int ID)
    {
        Debug.Log($"selected weapon: {Weapon} {ID}");
    }
}
