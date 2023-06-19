using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WeaponSelect : MonoBehaviour
{
    public Sprite NewImage;
    public GameObject button;
    public Image GunSlot;

    public void ChooseWeapon()
    {
        GunSlot.sprite = NewImage;
    }
}
