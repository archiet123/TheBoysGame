using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer MusicMixer;
    public AudioMixer SFXMixer;
    public void SFXVolume(float SFXVol)
    {
        SFXMixer.SetFloat("SFXVolume", SFXVol);
    }

    public void MusicVolume(float MusicVol)
    {
        MusicMixer.SetFloat("MusicVolume", MusicVol);
    }
}
