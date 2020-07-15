using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public AudioMixer _MasterMixer;

    public void SetMasterVolume(float volume){
        _MasterMixer.SetFloat ("MasterVolume", volume);
    }

    public void SetBGMVolume(float volume){
        _MasterMixer.SetFloat ("BGMVolume", volume);
    }

    public void SetSFXVolume(float volume){
        _MasterMixer.SetFloat ("SFXVolume", volume);
    }

}