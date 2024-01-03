using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreShow : MonoBehaviour
{
    public Text ScoreText;
    public Text BestScore;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score : " + Score.ScoreCount;
        if(!PlayerPrefs.HasKey("BestScoredata"))
        {
            PlayerPrefs.SetInt("BestScoredata", 0);
        }
        if(PlayerPrefs.GetInt("BestScoredata") < Score.ScoreCount)
        {
            PlayerPrefs.SetInt("BestScoredata", Score.ScoreCount);
        }
        BestScore.text = "Best : " + PlayerPrefs.GetInt("BestScoredata");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
