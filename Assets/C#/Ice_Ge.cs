using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Ge : MonoBehaviour
{
    public GameObject IceCream;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IceGe", 2f, 3f);
    }

    void IceGe()
    {
        Instantiate(IceCream,new Vector3(-134.36f, -67f, 0f), Quaternion.identity);
    }
}
