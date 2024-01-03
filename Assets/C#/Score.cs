using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshPro Scorepoint;
    public static int ScoreCount;
    public static int BestScoreCount;

    void Start()
    {
        ScoreCount = 0;
        if (PlayerPrefs.GetInt("ChangeSky") == 0)
        {
            Scorepoint.color = Color.black;
        }
        if (PlayerPrefs.GetInt("ChangeSky") == 1)
        {
            Scorepoint.color = Color.white;
        }
    }

    void Update()
    {
        Scorepoint.text = ScoreCount.ToString();
    }
}
