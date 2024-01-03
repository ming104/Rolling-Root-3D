using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Obj : MonoBehaviour
{
    public float Destorytime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Destorytime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
