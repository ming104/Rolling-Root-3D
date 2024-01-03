using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUP : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "point")
        {
            Score.ScoreCount += 1;
            //Debug.Log("+1");
        }
    }
}
