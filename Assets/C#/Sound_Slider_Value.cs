using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Slider_Value : MonoBehaviour
{
    public Slider Song_Slider;
    public Slider Sound_Effect_Slider;
    public static float Song_volume_Slider = 0.5f;
    public static float Sound_Effect_volume_Slider = 0.5f;
    //public float Song_volume_Slider_Save;
    //public float Sound_Effect_volume_Slider_Save;

    void Awake()
    {
        if(!PlayerPrefs.HasKey("SVSS"))
        {
            PlayerPrefs.SetInt("SVSS", 5);
        }
        if(!PlayerPrefs.HasKey("SEVSS"))
        {
            PlayerPrefs.SetInt("SEVSS", 5);
        }
        Song_Slider.value = PlayerPrefs.GetInt("SVSS");
        Sound_Effect_Slider.value = PlayerPrefs.GetInt("SEVSS");
    }

    public void SoundBtnClick()
    {
       // Song_volume_Slider = Song_Slider.value;
        PlayerPrefs.SetInt("SVSS", (int)Song_Slider.value);
        //Sound_Effect_volume_Slider = Sound_Effect_Slider.value;
        PlayerPrefs.SetInt("SEVSS", (int)Sound_Effect_Slider.value);
    }
}
