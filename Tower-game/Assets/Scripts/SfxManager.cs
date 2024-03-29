﻿using UnityEngine.Audio;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public SfxSounds sound;
    void Awake() {
        sound.source = gameObject.AddComponent<AudioSource>();
        sound.source.volume = sound.volume;
        sound.source.pitch = sound.pitch;
        sound.source.loop = sound.loop;
        sound.source.outputAudioMixerGroup = sound.audioMixerGroup;
        sound.isAttacking = false;
        
        InvokeRepeating("playRandomClip", sound.startingTime, sound.repeatingTime);
    }
    
    void setRandomClip(AudioClip[] clips){
        int clipIndex = (int) Random.Range(0, ((float) (clips.Length) - 0.5f));
        sound.source.clip = clips[clipIndex];
    }

    public void playRandomClip() {
        if (sound.isAttacking)
        {
            sound.repeatingTime = 5f;
            setRandomClip(sound.attackClips);
        } else
        {
            setRandomClip(sound.walkingClips);
        }
        sound.source.Play();
    }
}
