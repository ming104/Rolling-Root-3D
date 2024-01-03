using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyBoxChange_Drop : MonoBehaviour
{
    public Dropdown ChangeSky;

    void Awake()
    {
        if(!PlayerPrefs.HasKey("ChangeSky"))
        {
            PlayerPrefs.SetInt("ChangeSky", 0);
        }
        ChangeSky.value = PlayerPrefs.GetInt("ChangeSky");
    }

    public void ButtonSky()
    {
        PlayerPrefs.SetInt("ChangeSky", ChangeSky.value);
    }
    
}
