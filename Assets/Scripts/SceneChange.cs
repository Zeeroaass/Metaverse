using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public void LoadMinigame()
    {
        SceneManager.LoadScene("MinigameScene");
        Time.timeScale = 0;
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
