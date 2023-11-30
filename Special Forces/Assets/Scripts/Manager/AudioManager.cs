using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Sound
{
    public AudioClip[] audioClip; 
}


public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] AudioSource scenerySource;
    [SerializeField] AudioSource effectSource;

    public void Sound(AudioClip audioClip)
    {
        effectSource.PlayOneShot(audioClip);
    }
}
