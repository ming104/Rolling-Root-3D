using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCam : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Text;
    public GameObject Root;

    void Update()
    {
        transform.rotation = Cam.transform.rotation;
        Text.transform.position = new Vector3(Root.transform.position.x , Root.transform.position.y + 1.2f, Root.transform.position.z);

    }
}