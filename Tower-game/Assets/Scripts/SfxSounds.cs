using UnityEngine.Audio;
using UnityEngine;
using System;

[System.Serializable]
public class SfxSounds
{
    public string name;
    public AudioClip[] attackClips;
    public AudioClip[] walkingClips;
    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;
    public bool loop;
    public float startingTime;
    public float repeatingTime;
    [HideInInspector]
    public bool isAttacking;
    [HideInInspector]
    public AudioSource source;
    public AudioMixerGroup audioMixerGroup;
}
