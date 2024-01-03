using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Ice_Cream : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(15f, 7f, 0) * Time.deltaTime);
    }
}
