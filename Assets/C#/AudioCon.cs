using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCon : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip Pico1AS;
    public AudioClip Pico3AS;
    bool Pico1Played = false;

    void Start() 
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        if (!Pico1Played)
        {
            Invoke("Play_Pico3", 11.36f);
            audioSource.clip = Pico1AS;
            audioSource.Play();
            Pico1Played = true;  
        }
        else
        {
            Invoke("Play_Pico3", 11.3f);
        }
    }

    void Play_Pico3()
    {
        audioSource.clip = Pico3AS;
        audioSource.Play();
        Start();
    }
}
