using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bic_Ge : MonoBehaviour
{
    public GameObject Bicycle;
    public AudioSource ddlrangddlrang;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BicycleGe", 10f, 1f);
    }

    void BicycleGe()
    {
        if(Random.Range(1, 101) > 95)//95
        {
            Instantiate(Bicycle);
            ddlrangddlrang.Play();
        }
    }
}
