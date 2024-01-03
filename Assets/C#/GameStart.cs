using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject Settingpanel;
    void Awake()
    {
        Settingpanel.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Play");
    }
    public void Setting()
    {
        Settingpanel.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
