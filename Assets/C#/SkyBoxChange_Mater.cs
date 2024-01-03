using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyBoxChange_Mater : MonoBehaviour
{
    public Material SkyBox1;
    public Material SkyBox2;
    
    void Awake()
    {
        if(PlayerPrefs.GetInt("ChangeSky") == 0)
        {
            RenderSettings.skybox = SkyBox1;
        }
        if(PlayerPrefs.GetInt("ChangeSky") == 1)
        {
            RenderSettings.skybox = SkyBox2;
        }
    }
}
