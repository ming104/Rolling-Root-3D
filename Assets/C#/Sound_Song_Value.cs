using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Song_Value : MonoBehaviour
{
    public AudioSource Song;
    public AudioSource Sound_Effect_RootJump;
    public AudioSource Sound_Effect_GameStart;
    public AudioSource Sound_Effect_bikeSound;
    public AudioSource Sound_Effect_Slow_bikeSound;

    void Awake()
    {
        Song.volume = PlayerPrefs.GetInt("SVSS")/10f;
        Sound_Effect_RootJump.volume = PlayerPrefs.GetInt("SEVSS")/10f;
        Sound_Effect_GameStart.volume = PlayerPrefs.GetInt("SEVSS")/10f;
        Sound_Effect_bikeSound.volume = PlayerPrefs.GetInt("SEVSS")/10f;
        Sound_Effect_Slow_bikeSound.volume = PlayerPrefs.GetInt("SEVSS") / 10f;
    }
}
