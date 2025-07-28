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
        ScoreManager.Instance.SaveHighScore(); // 최고 점수 저장
        PlayerPrefs.SetInt("LastScore", ScoreManager.Instance.score); // 현재 점수 저장
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }
}
