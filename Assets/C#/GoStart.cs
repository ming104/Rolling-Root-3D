using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStart : MonoBehaviour
{
    public AudioSource dead;
    // Start is called before the first frame update
    void Awake()
    {
        dead.volume = PlayerPrefs.GetInt("SEVSS")/10f;
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
