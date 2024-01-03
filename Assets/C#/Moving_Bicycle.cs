using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Bicycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-40f, -18.65f, 0) * Time.deltaTime);
    }
}
