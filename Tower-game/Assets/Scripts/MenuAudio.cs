using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuAudio : MonoBehaviour
{

    public AudioMixer _MasterMixer;
    public Slider masterSlider;
    public Slider bGMSlider;
    public Slider sFXSlider;
    private void Start() {
        SetSlider("MasterVolume", masterSlider);
        SetSlider("BGMVolume", bGMSlider);
        SetSlider("SFXVolume", sFXSlider);
    }
    public void SetSlider(string name, Slider slider){
        float value;
        bool result = _MasterMixer.GetFloat(name, out value);
        if (result)
        {
            slider.value = value;
        }
    }
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