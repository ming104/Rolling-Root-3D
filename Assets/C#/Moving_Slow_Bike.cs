using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Slow_Bike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-20f, -9.325f, 0) * Time.deltaTime);
    }
}
