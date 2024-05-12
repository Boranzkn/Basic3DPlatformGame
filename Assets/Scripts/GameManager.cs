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
    [SerializeField] GameObject nextLevelPanel;

    public void AddScore(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }

    public void LevelUp()
    {
        nextLevelPanel.SetActive(true);
        winText.text = "Congratulations!\nScore: " + score;
        Invoke("GoNextLevel", 1.5f);
    }

    public void GoNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}