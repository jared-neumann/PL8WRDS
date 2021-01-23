using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    
    public AudioMixer audioMixer;

    public void SetMusicVolume(float musicVolume){

        audioMixer.SetFloat("musicVolume", musicVolume);

    }

    public void SetSFXVolume(float sfxVolume){

        audioMixer.SetFloat("sfxVolume", sfxVolume);

    }

}
