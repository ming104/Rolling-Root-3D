using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike_Color : MonoBehaviour
{
    public MeshRenderer Bike;
    public Material BikeMaterialMornings;
    public Material BikeMaterialNight;

    // Start is called before the first frame update
    void Awake()
    {
        if(PlayerPrefs.GetInt("ChangeSky") == 0)
        {
            Bike.material = BikeMaterialMornings;
        }
        if (PlayerPrefs.GetInt("ChangeSky") == 1)
        {
            Bike.material = BikeMaterialNight;
        }
    }
}
