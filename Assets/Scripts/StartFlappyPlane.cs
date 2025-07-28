using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFlappyPlane : MonoBehaviour
{
    public GameObject uibutton;
    public void StartFlappy()
    {
        uibutton.SetActive(false);
        Time.timeScale = 1;
    }
}
