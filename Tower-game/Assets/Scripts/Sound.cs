using UnityEngine.Audio;
using UnityEngine;
using System;

[System.Serializable]
public class Sound {
   
    public string name;
    public AudioClip clip; = audioMixer.FindMatchingGroups(mixerOutput);
    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;
    
    public bool loop;

    [HideInInspector]
    public AudioSource source;

    // public AudioMixer _MasterMixer;
    public AudioMixerGroup audioMixerGroup;
}
