using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Circle_die : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
       
       SceneManager.LoadScene("Die");
       
    }
}

