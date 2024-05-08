using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    PlayerController playerController;
    bool isGameEnded = false;
    int score = 0;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject nextLevelPanel;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    public void RespawnPlayer()
    {
        if (!isGameEnded)
        {
            isGameEnded = true;
            StartCoroutine("RespawnCoroutine");
        }
    }

    private IEnumerator RespawnCoroutine()
    {
        playerController.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameEnded = false;
    }

    public void AddScore(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }

    public void LevelUp()
    {
        nextLevelPanel.SetActive(true);
        Invoke("GoNextLevel", 2f);
    }

    public void GoNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}



// Turkiye Sigorta
// Hangi belgeler
// Süre geçti sıkıntı olmasın
// Süre geçti sıkıntı olmasın
// 3381414 
//  239