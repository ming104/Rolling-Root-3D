using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject ExitP;

    void Start()
    {
        ExitP.SetActive(false);
    }

    public void ExitPanel()
    {
        ExitP.SetActive(true);
    }

    public void ExitPanelEnd()
    {
        ExitP.SetActive(false);
    }
}
