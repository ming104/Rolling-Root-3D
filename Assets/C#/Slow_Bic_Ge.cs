using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow_Bic_Ge : MonoBehaviour
{
    public GameObject Bicycle;
    public AudioSource drrdrr;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BicycleGe", 10f, 1f);
    }

    void BicycleGe()
    {
        int a;
        if (Random.Range(100, 201) > 195)
        {
            Instantiate(Bicycle);
            drrdrr.Play();
        }
    }
}
