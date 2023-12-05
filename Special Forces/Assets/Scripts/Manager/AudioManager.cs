<<<<<<< Updated upstream
using System;
=======
<<<<<<< HEAD
=======
using System;
>>>>>>> 34b1a0ca68b044f18da83944e18964cc35e02e08
>>>>>>> Stashed changes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream
=======
<<<<<<< HEAD
[System.Serializable]
public class Sound
{
    public AudioClip [ ] audioClip;    
}

=======
>>>>>>> Stashed changes
[Serializable]
public class Sound
{
    public AudioClip[] audioClip; 
}


<<<<<<< Updated upstream
=======
>>>>>>> 34b1a0ca68b044f18da83944e18964cc35e02e08
>>>>>>> Stashed changes
public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] AudioSource scenerySource;
    [SerializeField] AudioSource effectSource;

    public void Sound(AudioClip audioClip)
    {
        effectSource.PlayOneShot(audioClip);
    }
}
