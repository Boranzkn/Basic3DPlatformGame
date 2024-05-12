using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text winText;
    [SerializeField] TMP_Text levelText;
    [SerializeField] GameObject nextLevelPanel;

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex > 1)
        {
            ShowLevel();
        }
    }

    public void AddScore(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }

    public void LevelUp()
    {
        nextLevelPanel.SetActive(true);
        winText.text = "Congratulations!\nScore: " + score;
        Invoke("GoNextLevel", .5f);
    }

    public void GoNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void ShowLevel()
    {
        int levelNum = SceneManager.GetActiveScene().buildIndex - 1;
        levelText.text = "Level " + levelNum.ToString();
    }
}